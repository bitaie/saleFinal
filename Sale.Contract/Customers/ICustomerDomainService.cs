
using Sale.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Contract.Customers
{
    public interface  ICustomerDomainService
    {
        string IsDuplicateInsert(Customer customer);
        List<string> CheckCustomerRequiredFieldsFilled(Customer customer, List<string> requiredFields);
        List<string> CheckCustomerFieldsUpperLimitLengthRight(Customer customer, Dictionary<string, int> limitedFields);
        //bool CheckCustomerFieldsHaveCorrectFormat(Customer customer);

        List<string> CheckPhoneNumberFormat(Customer customer, string correctPhoneNumberExample);


    }

}
