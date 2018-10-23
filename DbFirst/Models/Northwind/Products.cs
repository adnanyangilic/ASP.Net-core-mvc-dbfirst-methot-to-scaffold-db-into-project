using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DbFirst.Models.Northwind
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters", MinimumLength = 5)]
        [RegularExpression(@".+")]
        [Display(Name = "Product Name", Order = 120)]
        public string ProductName { get; set; }

        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }

        [Display(Order = 121)]
        public string QuantityPerUnit { get; set; }

        [Range(0, 60000)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal? UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        [ReadOnly(true)]
        public short? UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        public short? UnitsOnOrder { get; set; }

        [Compare("UnitsOnOrder")]
        [ScaffoldColumn(false)]
        [HiddenInput]
        public short? ReorderLevel { get; set; }

        [ScaffoldColumn(false)]
        public bool? Discontinued { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime Created { get; set; }

        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
