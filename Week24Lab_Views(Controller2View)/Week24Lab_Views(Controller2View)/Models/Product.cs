using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week24Lab_Views_Controller2View_.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
        public string Colour { get; set; }

        [Range(typeof(decimal),"30.00", "1000.00")]
        public decimal Price { get; set; }

    }
}