using Sale.Domain.BaseEntities;
using Sale.Domain.Invoices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Customers
{
    //[JsonObject(MemberSerialization.OptIn)]
    //[Serializable]
    //[DataContract]
    public class Customer :BaseEntity
    {
    
        //[Required]
       // [MaxLength(50)]
        //[JsonProperty]
        //[DataMember]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        //[Required]
        //[MaxLength(50)]
        //[JsonProperty]
        //[DataMember]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        //[Required]
        ////[JsonProperty]
        //[DataMember]

        public string PhoneNumber { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

    }
}
