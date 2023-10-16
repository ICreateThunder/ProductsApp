﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        [StringLength(10)]
        public string ProductName {  get; set; }
        [Required(ErrorMessage ="Price is required")]
        [Range(0, 100, ErrorMessage = "Price must be between £0 and £1000")]
        public decimal Price { get; set; }
        [DisplayName("Description")]
        [StringLength(50)]
        public string Description {  get; set; }
    }
}