using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.BaseEntities
{
    public class BaseEntity
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        //public DateTime AddedDate
        //{
        //    get;set;
        //    //get
        //    //{
        //    //    return AddedDate;
        //    //}

        //    //set { AddedDate = DateTime.Now; }
        //}
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public DateTime AddedDate { get; set; } = DateTime.Now;
        //public string IPAddress { get; set; }
    }
}
