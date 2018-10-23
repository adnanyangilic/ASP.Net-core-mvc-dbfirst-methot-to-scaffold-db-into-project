using DbFirst.Models.CustomValidations;
using System;
using System.Collections.Generic;

namespace DbFirst.Models.Northwind
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CategoryId { get; set; }

        [ExcludeChar(@"%$.~")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
