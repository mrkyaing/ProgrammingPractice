using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleMVCProject.Models
{
    public class ProductModel
    {
        [Required]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UintPrice { get; set; }
    }
}