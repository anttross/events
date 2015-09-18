using System;
using System.ComponentModel.DataAnnotations;

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
        [DisplayFormat(DataFormatString = "{0:HH:mm dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public Events()
        {
            this.Date = DateTime.Now;
        }
    }
}