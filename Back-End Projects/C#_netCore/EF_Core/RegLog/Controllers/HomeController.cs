using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegLog.Models;

namespace RegLog.Controllers
{
    public class HomeController : Controller
    {
        private LogRegContext _context;
        
        
        public HomeController(LogRegContext context)
        {
            _context = context;
            
        }
        
        public IActionResult Index()
        {
            IEnumerable<RegUser> _regs = _context.users.ToList();
            VM model = new VM(){
                Regs = _regs
            };
            return View(model);
        }

        [HttpPost("Register")]
        public IActionResult Register(VM _model){
            if(ModelState.IsValid)
            {
                RegUser _user = _model.Reg;
                _context.Add(_user);
                _context.SaveChanges();
                return View("Log",_user);
            }
            IEnumerable<RegUser> _regs = _context.users.ToList();
            VM model = new VM(){
                Regs = _regs
            };
            return View("Index",model);
        }

        [HttpPost("Log")]
        public IActionResult Log(VM _model){
            if(ModelState.IsValid)
            {
                LogUser _user = _model.Log;
                RegUser ruser = _context.users.SingleOrDefault(user => user.email == _user.email);
                if(_user.password == ruser.password)
                {
                    ViewBag.Info = "Success!";
                    return View("Log",ruser);
                }
                else
                {
                    ViewBag.Info = "Failure!";
                }
            }
            return View("Fail");
        }

   
    }
}
