using System;
using System.ComponentModel.DataAnnotations;

namespace EF_Demo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }
    }
}
