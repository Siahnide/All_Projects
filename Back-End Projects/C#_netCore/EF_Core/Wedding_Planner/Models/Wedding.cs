using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Wedding_Planner.Models
{
    public class Wedding
    {
        [Key]
        public int id { get; set; }
        public string address {get;set;}
        public string wedder_1 { get; set; }
        public string wedder_2 { get; set; } 
        public DateTime date { get; set; }
        public RegUser planner { get; set; }
        public IEnumerable<RegUser> guests { get; set; }
        public bool Attending(RegUser active)
        {
            foreach(RegUser user in guests)
            {
                if(user.id == active.id)
                {
                    return true;
                }
            }
            return false;
        }
 
        
    }
}