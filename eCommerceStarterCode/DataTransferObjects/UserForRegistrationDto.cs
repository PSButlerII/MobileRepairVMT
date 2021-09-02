using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;

namespace MobileRepairMT.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string PhoneNumber { get; set; }
        public bool IsOwner { get; set; }

    }
}