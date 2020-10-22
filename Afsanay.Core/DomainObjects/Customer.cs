using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Afsanay.Core.DomainObjects
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [StringLength(45)]
        public string Name { get; set; }
        public int Age { get; set; }
        [StringLength(45)]
        public string Profession { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(45)]
        public string City { get; set; }
        [StringLength(11)]
        public string ContactNo { get; set; }
        [StringLength(45)]
        public string Email { get; set; }
        [Required]
        public bool Gender { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
