using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_Demo.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

