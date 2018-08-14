using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Secrets.Models
{
    public class RegUser
    {
        [Key]
        public int id {get;set;}
        [Required]
        public string first_name {get;set;}

        [Required]
        public string last_name {get;set;}

        [Required]
        [EmailAddress]
        public string email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string password {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirm{get;set;}
        public IEnumerable<Secrets> created_secrets {get;set;}
        public IEnumerable<Like> likes {get;set;}
    }
}