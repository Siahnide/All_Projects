using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Secrets.Models
{
    public class Secrets
    {
        [Key]
        public int id {get;set;}
        public int user_id {get;set;}
        public string content {get;set;}
        public IEnumerable<Like> likes {get;set;}
        
    }
}