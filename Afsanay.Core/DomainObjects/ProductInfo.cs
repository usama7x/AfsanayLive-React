using Afsanay.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Afsanay.Core.DomainObjects
{
    public class ProductInfo
    {
        public int ProductInfoId { get; set; }
        public Size Size { get; set; }
        public string Color { get; set; }
        public int ProductId { get; set; }
        // EF Core Navigational property
        public virtual Product Product { get; set; }
    }
}
