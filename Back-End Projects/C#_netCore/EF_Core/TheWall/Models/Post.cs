using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TheWall.Models;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TheWall.Models
{
    public class Post
    {
        [Key]
        public int id {get;set;}
 
        public RegUser _user {get;set;}
        public int _userid {get;set;}
        public string content {get;set;}
        public IEnumerable<Comment> comments {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;


    }
}