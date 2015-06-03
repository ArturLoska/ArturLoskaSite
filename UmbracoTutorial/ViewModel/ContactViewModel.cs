using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoTutorial.ViewModel
{
    public class ContactViewModel
    {
        [Required]
        public string Nickname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Enter a message")]
        public string Message { get; set; }      

    }
}