using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Demo.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public int CustomerId { get; set; }

        public string Number { get; set; }

        public decimal ChargeAmount { get; set; }

        public decimal PayedAmount { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
