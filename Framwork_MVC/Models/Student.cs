using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Framwork_MVC.Models
{
    public class Student
    {
      public int StudentID { get; set; }
    [DataType(DataType.Text)]
    [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
    [Display(Name = "Student Name")]

    public string Name { get; set; }
    //[MaxLength(3), MinLength(1)]
    [Required(ErrorMessage = "Please enter marks")]
    public int Marks { get; set; }

    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Please enter Email ID")]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]

    public string Email { get; set; }
    [Required(ErrorMessage = "Please enter department")]

    public string Department { get; set; }

  
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }

    }
}
