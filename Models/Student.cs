using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoProject.Models
{
    public class Student
    {

        public int Id { get; set; }

        public string Name { get; set; }
     
        public int BirthDate { get; set; }
      
        
        public string Email { get; set; }
        
        public string ContactNo { get; set; }
    
        public string HighestEducation { get; set; }
        

    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}