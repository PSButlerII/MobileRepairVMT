using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MobileRepairMT.Models
{
    public class Review   
    {      

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("ShopService")]
        public int ServiceId { get; set; }
        public ShopService Service { get; set; }

        [Key]
        public string UserReview { get; set; }
        public int Rating { get; set; }
    }
}
