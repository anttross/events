using System.ComponentModel.DataAnnotations;

namespace Event.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required(ErrorMessage = "יש להכניס סיסמא נוכחית")]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמא נוכחית")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "יש להכניס סיסמא חדשה")]
        [StringLength(100, ErrorMessage = "ה{0} חייבת להכיל {2} תווים לפחות.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמא חדשה")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "יש להכניס סיסמא חדשה שנית")]
        [DataType(DataType.Password)]
        [Display(Name = "אימות סיסמא")]
        [Compare("NewPassword", ErrorMessage = "הסיסמא החדשה ואימות הסיסמא החדשה לא תואמים.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "* יש להכניס שם משתמש")]
        [Display(Name = "שם משתמש")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "* יש להכניס סיסמא")]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמא")]
        public string Password { get; set; }

        [Display(Name = "זכור אותי")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "* יש להכניס שם משתמש")]
        [Display(Name = "שם משתמש")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "* יש להכניס דוא\"ל")]
        [Display(Name = "דוא\"ל")]
        [EmailAddress(ErrorMessage = "דוא\"ל שגוי")]
        public string Email { get; set; }

        [Required(ErrorMessage = "* יש להכניס שם פרטי")]
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* יש להכניס שם משפחה")]
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* יש להכניס סיסמא")]
        [StringLength(100, ErrorMessage = "ה{0} חייבת להכיל {2} תווים לפחות.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמא")]
        public string Password { get; set; }

        [Required(ErrorMessage = "* יש להכניס אימות סיסמא")]
        [DataType(DataType.Password)]
        [Display(Name = "אימות סיסמא")]
        [Compare("Password", ErrorMessage = "הסיסמא ואימות הסיסמא לא תואמים.")]
        public string ConfirmPassword { get; set; }
    }
}
