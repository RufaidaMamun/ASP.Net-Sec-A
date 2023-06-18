using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentForm.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please provide your name")]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        public string StudentID { get; set; }

        public string StudentEmail { get; set; }
    }
}