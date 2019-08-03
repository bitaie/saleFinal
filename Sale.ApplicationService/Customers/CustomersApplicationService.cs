using Sale.Contract.Common;
using Sale.Contract.Customers;
using Sale.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.ApplicationService.Customers
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private readonly ICustomerDomainService _customerDomainService;
        private readonly IGenericRepository<Customer> _customerRepository;
        private static List<string> requiredFields = new List<string>() { "FirstName","LastName","PhoneNumber"}; 
        private static Dictionary<string,int> limitedFields = new Dictionary<string, int>() { { "FirstName",5 },{ "LastName", 50 },{ "PhoneNumber", 11} };
        private static string correctPhoneNumberExample = "09123456789";
        public CustomerApplicationService(ICustomerDomainService customerDomainService, IGenericRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
            _customerDomainService = customerDomainService;
           
        }

       public object SubmitCustomer(Customer customer)
        {
            try
            {
                List<string> errors;
                List<string> customerRequireedFilledErrors = new List<string>();
                 customerRequireedFilledErrors = _customerDomainService
                    .CheckCustomerRequiredFieldsFilled(customer, requiredFields);
                List<string> customerFieldsUpperLimitLengthRightErrors = new List<string>();
                customerFieldsUpperLimitLengthRightErrors = _customerDomainService
                    .CheckCustomerFieldsUpperLimitLengthRight(customer, limitedFields);
                List<string> customerPhoneNumberFormatErrors = new List<string>();
               customerPhoneNumberFormatErrors = _customerDomainService
                    .CheckPhoneNumberFormat(customer, correctPhoneNumberExample);

                if (customerRequireedFilledErrors.Any() || customerFieldsUpperLimitLengthRightErrors.Any() || customerPhoneNumberFormatErrors.Any())

                {
                   return errors = customerRequireedFilledErrors
                        .Concat(customerFieldsUpperLimitLengthRightErrors).Concat(customerPhoneNumberFormatErrors).ToList();

                }
               
                      
                   
                    var IsDuplicateInsertError = _customerDomainService.IsDuplicateInsert(customer);
                    if (IsDuplicateInsertError != null)
                    {

                        return IsDuplicateInsertError;
                    }
                    
                    return _customerRepository.Insert(customer);
                
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public object UpdateCustomer(Customer customer)
        {
            List<string> errors;
            List<string> customerRequireedFilledErrors = new List<string>();
            customerRequireedFilledErrors = _customerDomainService.CheckCustomerRequiredFieldsFilled(customer, requiredFields);
            List<string> customerFieldsUpperLimitLengthRightErrors = new List<string>();
             customerFieldsUpperLimitLengthRightErrors = _customerDomainService
                .CheckCustomerFieldsUpperLimitLengthRight(customer, limitedFields);
            List<string> customerPhoneNumberFormatErrors = new List<string>();
            customerPhoneNumberFormatErrors = _customerDomainService
                 .CheckPhoneNumberFormat(customer, correctPhoneNumberExample);


            if (customerRequireedFilledErrors.Any() || customerFieldsUpperLimitLengthRightErrors.Any() || customerPhoneNumberFormatErrors.Any())

            {
                return errors = customerRequireedFilledErrors
                     .Concat(customerFieldsUpperLimitLengthRightErrors).Concat(customerPhoneNumberFormatErrors).ToList();

            }
            var IsDuplicateInsertError = _customerDomainService.IsDuplicateInsert(customer);
            if (IsDuplicateInsertError != null)
            {

                return IsDuplicateInsertError;
            }
             return _customerRepository.Update(customer);

        }
        public object DeleteCustomer(int id)
        {

          
               return _customerRepository.Delete(id);
         
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.Get(x=>x.Id==id).FirstOrDefault();
        }

    }
}
