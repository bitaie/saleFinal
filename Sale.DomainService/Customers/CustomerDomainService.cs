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

namespace Sale.DomainService.Customers
{
    public class CustomerDomainService : ICustomerDomainService
    {
        private readonly AppDbContext _context = null;
        private readonly IGenericValidation<Customer> _customerValidation;
        private readonly IGenericRepository<Customer> _customerRepository;

        public CustomerDomainService(AppDbContext ctx, IGenericRepository<Customer> customerRepository, IGenericValidation<Customer> customerValidation)
        {
            _context = ctx;
            _customerRepository = customerRepository;
            _customerValidation = customerValidation;
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
       
        }









    }

