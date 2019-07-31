using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Dto
{
    public class InsertItemDto
    {
        public Item item { get; set; }
        public int invoiceId { get; set; }
    }
}
