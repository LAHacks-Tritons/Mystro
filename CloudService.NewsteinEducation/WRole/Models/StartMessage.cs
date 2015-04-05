using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace WRole.Models
{
    public class StartMessage
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        public string Name { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "The message is required")]
        public string Message { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string Email { get; set; }
 
    }
}