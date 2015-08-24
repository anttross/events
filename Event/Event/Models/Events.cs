using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Event.Models
{
    public class Events
    {
        public int ID { get; set; }

        [Display(Name = "מספר")]
        public string ApplicationUserID { get; set; }

        [Display(Name = "שם")]
        [Required(ErrorMessage = "* יש להכניס שם")]
        public string Event { get; set; }

        [Display(Name = "תאריך")]
        [Required(ErrorMessage = "* יש להכניס תאריך")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", HtmlEncode = true, ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}