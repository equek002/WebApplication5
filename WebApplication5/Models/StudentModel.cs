using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Models
{
    public class StudentModel
    {

        [Required(ErrorMessage = "Student Name is required.")]
        public string Name { get; set;}
        [Required(ErrorMessage = "Student Class is required.")]
        public string Class { get; set; }
    }
}