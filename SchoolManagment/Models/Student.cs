using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagment.Models
{
    public class Student
    {
        [Required]
        [StringLength(10)]
        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]
        public string RollNo { get; set; }
        [Required]
        public string StudentName { get; set; }
        
    }
}