

using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Contract.Invoices
{
    public interface IInvoiceDomainService
    {
    

        int CalculateTotalPrice(List<Item> items);
      

    }
}
