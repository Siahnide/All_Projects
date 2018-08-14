using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheWall.Models
{
    public class Comment 
    {
        [Key]
        public int id {get;set;}
        public Post _post {get;set;}
        public int _postid {get;set;}
        public RegUser _user {get;set;}
        public int _userid {get;set;}
        public string content {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;
    }
}