using Sale.Contract.Customers;
using Sale.Domain.Customers;
using Sale.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Sale.Contract.Common;
using Sale.Domain.Customers;
using Sale.Infrastructure.Validations;
using Sale.Contract.Customers;
using System.Text.RegularExpressions;

namespace Sale.DomainService.Customers
{
    public class CustomerDomainService : ICustomerDomainService
    {
        private readonly AppDbContext _context = null;
        private readonly IGenericValidation<Customer> _customerValidation;
        private readonly IGenericValidationService _genericValidationService;
        private readonly IGenericRepository<Customer> _customerRepository;
       

        public CustomerDomainService(AppDbContext ctx, IGenericRepository<Customer> customerRepository,
            IGenericValidation<Customer> customerValidation,IGenericValidationService genericValidationService)
        {
            _context = ctx;
            _customerRepository = customerRepository;
            _customerValidation = customerValidation;
            _genericValidationService = genericValidationService;
        }
        public string IsDuplicateInsert(Customer customer)

        {
            try
            {
                return _customerValidation.IsDuplicateInsert(customer);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public List<string> CheckCustomerRequiredFieldsFilled(Customer customer, List<string> requiredFields)
        {
            return _customerValidation.CheckEntityRequiredFieldsFilled(customer, requiredFields);
        }
        public List<string> CheckCustomerFieldsUpperLimitLengthRight(Customer customer, Dictionary<string, int> limitedFields)
        {

            return _customerValidation.CheckEntityFieldsUpperLimitLengthRight(customer, limitedFields);
        }
        public List<string> CheckPhoneNumberFormat(Customer customer,string correctPhoneNumberExample)
        {
            List<string> errors = new List<string>();
            var regex = @"(09)(12|19|35|36|37|38|39|32)\d{7}";
            var match = Regex.Match(customer.PhoneNumber, regex, RegexOptions.IgnoreCase);
            Type type = customer.GetType();


            System.Reflection.PropertyInfo propertyInfo = type.GetProperty("PhoneNumber");

            if (!match.Success)
            {
                errors.Add($"فرمت {_genericValidationService.GetPropertyDisplayNameIfExists(propertyInfo)}" +
                                     $"  اشتباه است. نمونه ی درست،{correctPhoneNumberExample } است.");
            }
                return errors;
           
        }
       
        }









    }

