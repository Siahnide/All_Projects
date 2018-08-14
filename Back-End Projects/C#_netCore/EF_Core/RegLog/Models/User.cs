using System.ComponentModel.DataAnnotations;
namespace RegLog.Models
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
        public string email {get;set;}
        public string password {get;set;}
    }
}