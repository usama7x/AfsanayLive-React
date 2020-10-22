using Afsanay.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Afsanay.Core.DomainObjects
{
    public class SaleOrder
    {
        public int SaleOrderId { get; set; }
        public int SaleOrderNo { get; set; }
        public DateTime Stamp { get; set; }
        public OrderStatus Status { get; set; }
        public double Freight { get; set; }
        public double TaxPercentage { get; set; }
        public double TaxAmount { get; set; }
        public double SubTotal { get; set; }
        public double DiscountPercentage { get; set; }
        public double DiscountAmount { get; set; }
        public DiscountType DiscountType { get; set; }
        public double TotalAmount { get; set; }
        [StringLength(300)]
        public string Comment { get; set; }
        public bool IsNewCustomer { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        public ICollection<SaleOrderDetails> SaleOrderDetails { get; set; }
    }
}
