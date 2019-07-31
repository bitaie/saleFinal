using Sale.Domain.BaseEntities;
using Sale.Domain.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Invoices
{
    public class Invoice: BaseEntity
    {
        //public int Id { get; set; }
         public virtual ICollection<Item> Items { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Display(Name = "Total Price")]
        public int TotalPrice { get; set; }




    }
}
