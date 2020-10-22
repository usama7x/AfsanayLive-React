using System;
using System.Collections.Generic;
using System.Text;

namespace Afsanay.Core.DomainObjects
{
    public class SaleOrderDetails
    {
        public int SaleOrderDetailsId { get; set; }
        public int SaleOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public DateTime Stamp { get; set; }
        public SaleOrder SaleOrder { get; set; }
        public virtual Product Product { get; set; }



    }
}
