using System;
using System.Collections.Generic;
using System.Text;

namespace Afsanay.Core.DomainObjects
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
