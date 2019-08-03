using Sale.Contract.Common;
using Sale.Domain.BaseEntities;
using Sale.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Infrastructure.Validations
{
    public class GenericValidation<T>:IGenericValidation<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _entityRepository;
        private readonly IGenericValidationService _genericVslidationService;
        public GenericValidation(IGenericRepository<T> entityRepository, IGenericValidationService genericValidationService)
        {
            _entityRepository = entityRepository;
            _genericVslidationService = genericValidationService;
        }

        public List<string> CheckEntityRequiredFieldsFilled(T obj, List<string> requiredFields)
        {

            PropertyInfo[] properties = typeof(T).GetProperties();
            List<string> errors = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                foreach (var requiredField in requiredFields)
                {
                    if (property.Name == requiredField)
                    {
                        var propertyValue = property.GetValue(obj);

                        if (propertyValue == null)
                        {
                            string error = $"{_genericVslidationService.GetPropertyDisplayNameIfExists(property)}" +
                                $" باید دارای مقدار باشد.";
                            errors.Add(error);
                        }
                    }
                }
            }
            return errors;
        }
        public List<string> CheckEntityFieldsUpperLimitLengthRight(T obj, Dictionary<string, int> limitedFields)
        {
            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                List<string> errors = new List<string>();
                foreach (PropertyInfo property in properties)
                {
                    if (property.PropertyType.Name != typeof(BaseEntity).Name && property.PropertyType.Name != typeof(ICollection<>).Name && !property.Name.EndsWith("Id"))
                     {
                   
                        foreach (var limitedField in limitedFields)
                        {
                            if (property.Name == limitedField.Key)
                            {
                                var propertyValue = property.GetValue(obj);
                                if (propertyValue != null)
                                {

                                    if (propertyValue.ToString().Length > limitedField.Value)
                                    {
                                        errors.Add($"طول {_genericVslidationService.GetPropertyDisplayNameIfExists(property)} " +
                                            $"دارای محدودیت تعداد {limitedField.Value} کاراکتر است.");
                                    }
                                }
                            }
                        }
                    }
                  
                }
                return errors;
            }
            catch (Exception ex) { return new List<string>(); }
        }
        public string IsDuplicateInsert(T obj)

        {
            try
            {
                PropertyInfo[] properties = typeof(T).GetProperties(System.Reflection.BindingFlags.Public 
                    | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.DeclaredOnly);

                string error = null;
                var isSame = true;
                List<T> entitiesInDb = _entityRepository.GetAll().ToList();
                if ( ! entitiesInDb.Any())
                {
                    isSame = false;
                }
                foreach (var entityInDb in entitiesInDb)
                {
                    //if all properties except id are same, it means the customer is already in database 

                    foreach (var property in properties)
                        
                    {
                       // var test1 = property.PropertyType.Name != typeof(ICollection<>).Name;


                        if (property.PropertyType.Name != typeof(BaseEntity).Name && 
                            property.PropertyType.Name != typeof(ICollection<>).Name &&
                            ! property.Name.EndsWith("Id")) {

                            if (property.GetValue(obj) == null)
                            {
                                isSame = false;
                            }
                            else
                            {
                                if (property.GetValue(entityInDb).ToString() != property.GetValue(obj).ToString())
                                {
                                    isSame = false;
                                }
                            }
                            }

                        }
                       
                    }
                    if (isSame == true )
                    {

                        error = "داده تکراری است!";

                    }
                
                return error;
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
