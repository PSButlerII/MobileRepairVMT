using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;



namespace MobileRepairMT.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }       
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        
        public ICollection<ProductShoppingCart> ShoppingCarts { get; set; }
        public ICollection<Review> Reviews { get; set; }       
    }
}
