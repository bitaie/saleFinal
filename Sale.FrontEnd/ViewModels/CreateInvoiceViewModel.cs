using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.FrontEnd.ViewModels
{
    public class CreateInvoiceViewModel
    {
        public Sale.Domain.Invoices.Invoice invoice { get; set; }
        public Item item { get; set; }
       
        public Dictionary<int, string> productsList { get; set; }
    }
}
