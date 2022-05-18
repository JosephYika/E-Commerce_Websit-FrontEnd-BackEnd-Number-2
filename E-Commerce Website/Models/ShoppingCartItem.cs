using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Website.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public PianoCourse PianoCourse { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
        
    }
}
