using System.ComponentModel.DataAnnotations;

namespace ValidationAttributeASPCore.Models
{
    public class Student
    {
        [Required (ErrorMessage = "Name Is Must")]
        //[StringLength (15, MinimumLength = 3)]
        //[MaxLength (15)]
        [MinLength (3 , ErrorMessage =" minimum length must be 3 character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Is Must")]
        //[EmailAddress]
        [RegularExpression(@"^([0-9a-zA-Z]([-\\\\.\\\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\\\w]*[0-9a-zA-Z]\\\\.)+[a-zA-Z]{2,9})$ ^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage = "Envalid Email")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "Age Is Must")]
        [Range (10, 50, ErrorMessage ="Range within 10 To 50")]
        public int Age { get; set; }

        //[Required(ErrorMessage = "Password Is Must")]
        //[RegularExpression(@" (?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z])")]
        //public string Password { get; set; }
        //[Required(ErrorMessage = "ConfirmPassword Is Must")]
        //[Compare("Password",ErrorMessage ="Both Passwords Are Identical")]
        //public string ConfirmPassword { get; set; }
        //[Required(ErrorMessage = "WebsiteURL Is Must")]
        //[Url(ErrorMessage = "Invalid Url")]
        //public string WebSiteURL { get; set; }
    }
}
