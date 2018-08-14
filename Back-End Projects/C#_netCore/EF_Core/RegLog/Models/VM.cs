using System.Collections.Generic;
namespace RegLog.Models
{
    public class VM
    {
        public IEnumerable<RegUser> Regs {get;set;}
        public RegUser Reg {get;set;}
        public LogUser Log {get;set;}
    }
}