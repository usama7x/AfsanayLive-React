using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Afsanay.Core.DomainObjects
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(45)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime Stamp { get; set; }
        [StringLength(500)]
        public string Description{ get; set; }
        public bool IsAvailable { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsRemoved { get; set; }
        public decimal Weight { get; set; }
        public int CategoryId { get; set; }
       // EF Core Navigational property
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
        public virtual ICollection<SaleOrderDetails> SaleOrderDetails { get; set; }

    }
}
