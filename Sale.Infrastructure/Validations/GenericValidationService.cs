using Sale.Contract.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Infrastructure.Validations
{
    public class GenericValidationService : IGenericValidationService
    {
        public string GetPropertyDisplayNameIfExists(PropertyInfo property)
        {
            var displayAttribute = property
         .GetCustomAttributes(typeof(DisplayAttribute), true)
         .FirstOrDefault() as DisplayAttribute;
            string displayName = property.Name;
            if (displayAttribute != null)
            {
               return displayName = displayAttribute.Name;
            }
            else
            {
                return property.Name;
            }
        }

}
}
