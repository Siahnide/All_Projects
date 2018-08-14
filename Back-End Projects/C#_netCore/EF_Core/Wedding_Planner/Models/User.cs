using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Wedding_Planner.Models
{
    public class RegUser
    {
        [Key]
        public int id {get;set;}
        [Required]
        [MinLength(2)]
        public string first_name {get;set;}

        [Required]
        [MinLength(2)]
        public string last_name {get;set;}

        [Required]
        [EmailAddress]
        public string email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string password {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Compare("password")]
        public string confirm {get;set;}
        

    }
    public class LogUser
    {
        
        [Required]
        [EmailAddress]
        public string email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string password {get;set;}
    }
    public class Guest
    {
        [Key]
        public int id {get;set;}
        public int user_id {get;set;}
        public int wedding_id {get;set;}
    }
}