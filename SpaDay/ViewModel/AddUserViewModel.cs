using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters long")]
        public string Username { get; set; }

        [EmailAddress /*(ErrorMessage = "Proper email format required." */]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 Characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verification required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 Characters long")]
        public string VerifyPassword { get; set; }
    }
}
