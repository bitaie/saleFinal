using Sale.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Contract.Common
{
    public interface IGenericValidation<T> where T : BaseEntity
    {
   
        List<string> CheckEntityRequiredFieldsFilled(T obj, List<string> requiredFields);
        List<string> CheckEntityFieldsUpperLimitLengthRight(T obj, Dictionary<string, int> limitedFields);
        string IsDuplicateInsert(T obj);
    }
}
