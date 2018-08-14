using System.Collections.Generic;

namespace Wedding_Planner.Models
{
    public class VM
    {
        public IEnumerable<Wedding> _weddings { get; set; }
        public Wedding _wedding {get;set;}
        public RegUser _reguser { get; set; }
        public LogUser _loguser { get; set; }
        
        
    }
}