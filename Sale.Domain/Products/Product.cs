
using Sale.Domain.BaseEntities;
using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Products
{
    public class Product:BaseEntity
    {
        [Display(Name = "نام محصول")]
        public string Name { get; set; }
        [Display(Name = "برند محصول")]
        public string Brand { get; set; }
        [Display(Name = "قیمت محصول")]
        public int Price { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
