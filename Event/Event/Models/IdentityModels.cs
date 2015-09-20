using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Event.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "* יש להכניס שם פרטי")]
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* יש להכניס שם משפחה")]
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* יש להכניס שם משתמש")]
        [Display(Name = "שם משתמש")]
        public override string UserName { get; set; }

        [Required(ErrorMessage = "* יש להכניס דוא\"ל")]
        [Display(Name = "דוא\"ל")]
        [EmailAddress(ErrorMessage = "דוא\"ל שגוי")]
        public override string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", HtmlEncode = true, ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        public virtual ICollection<Events> EventsList { get; set; }
    }
}