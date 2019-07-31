using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.Domain.Dto
{
    public class InsertInvoiceDto
    {
        public List<Item> items { get; set; }
        public Invoice invoice { get; set; }
    }
}
