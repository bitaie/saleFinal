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
        private static Dictionary<string,int> limitedFields = new Dictionary<string, int>() { { "FirstName",50 },{ "LastName", 50 },{ "PhoneNumber", 10} }; 
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
                var customerRequireedFilledErrors = _customerDomainService.CheckCustomerRequiredFieldsFilled(customer, requiredFields);
              

                if (customerRequireedFilledErrors.Any() )

                {
                    errors = customerRequireedFilledErrors;
                    return errors;

                }
                else
                {
                    var customerFieldsUpperLimitLengthRightErrors = _customerDomainService.CheckCustomerFieldsUpperLimitLengthRight(customer, limitedFields);

                    if (customerFieldsUpperLimitLengthRightErrors.Any())
                        errors = customerRequireedFilledErrors.Concat(customerFieldsUpperLimitLengthRightErrors).ToList();
                   
                    var IsDuplicateInsertError = _customerDomainService.IsDuplicateInsert(customer);
                    if (IsDuplicateInsertError != null)
                    {

                        return IsDuplicateInsertError;
                    }
                    return _customerRepository.Insert(customer);
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public object UpdateCustomer(Customer customer)
        {
            var customerRequireedFilledErrors = _customerDomainService.CheckCustomerRequiredFieldsFilled(customer, requiredFields);
            var customerFieldsUpperLimitLengthRightErrors = _customerDomainService.CheckCustomerFieldsUpperLimitLengthRight(customer, limitedFields);


            if (customerRequireedFilledErrors.Any() && customerFieldsUpperLimitLengthRightErrors.Any())

            {
                List<string> errors = customerRequireedFilledErrors.Concat(customerFieldsUpperLimitLengthRightErrors).ToList();
                return errors;


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
