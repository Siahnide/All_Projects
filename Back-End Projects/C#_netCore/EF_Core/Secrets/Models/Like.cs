using System.ComponentModel.DataAnnotations;

namespace Secrets.Models
{
    public class Like
    {
        [Key]
        public int id {get;set;}
        public int secret_id {get;set;}
        public int user_id {get;set;}
        public RegUser _user {get;set;}
        public Secrets _secret {get;set;}

    }
}