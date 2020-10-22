using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Afsanay.Core.Enums;

namespace Afsanay.Core.DomainObjects
{
    public class Category
    {
        public int CategoryId { get; set; }
        [StringLength(45)]
        public string Name { get; set; }        
        public CategoryType Type { get; set; }
        [StringLength(300)]
        public string Description { get; set; }      
        public bool IsRemoved { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
