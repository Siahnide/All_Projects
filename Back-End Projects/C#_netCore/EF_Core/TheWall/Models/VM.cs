using System.Collections.Generic;
namespace TheWall.Models
{
    public class VM
    {
        public IEnumerable<RegUser> Regs {get;set;}
        public IEnumerable<Post> posts {get;set;}
        public Post post {get;set;}
        public IEnumerable<Comment> comments {get;set;}
        public Comment comment {get;set;}
        public RegUser Reg {get;set;}
        public LogUser Log {get;set;}
        
        
    }
}