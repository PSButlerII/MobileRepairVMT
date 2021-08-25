﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace MobileRepairMT.Models
{
    public class ShoppingCart
    {   
        public int ShoppingCartId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Product")]
        public int ProductShoppingCartId { get; set; }
       

        [ForeignKey("Service")]
        public int ServiceShoppingCartId { get; set; }
        

    }
}
