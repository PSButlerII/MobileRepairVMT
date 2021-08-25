using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileRepairMT.Models
{
    public class ServiceShoppingCart
    {
        public int ServiceShoppingCartId { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("ShoppingCart")]
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
