using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }

        public double Price { get; set; }

        public int PianoCourseId { get; set; }

        public virtual PianoCourse PianoCourse { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public List<OrderItem> Orderitems { get; set; }
    }
}
