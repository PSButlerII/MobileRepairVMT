using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MobileRepairMT.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsOwner { get; set; }
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
