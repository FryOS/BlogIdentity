using BlogIdentity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogIdentity.Models

{
    public class ApplicationUser : IdentityUser
    {      
        
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }
       

    }
}
