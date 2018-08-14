using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    
    public class HomeController : Controller
    {
        public RegUser active {get{return _context.Users.SingleOrDefault(user=>user.id == HttpContext.Session.GetInt32("active"));}}
        private WeddingContext _context;

        public HomeController(WeddingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(VM model)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(user => user.email == model._reguser.email) == false)
                {
                    _context.Add(model._reguser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("active",model._reguser.id);
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(VM model)
        {
            if(ModelState.IsValid)
            {
                RegUser ruser = _context.Users.SingleOrDefault(user=>user.email == model._loguser.email);
                if(ruser.password == model._loguser.email)
                {
                    HttpContext.Session.SetInt32("active",ruser.id);
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }
        //ADD ACTIVE TO MODEL.REG.ID!  
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {

            RegUser user = new RegUser()
            {
                id = 1,
                first_name = "Barnser",
                last_name = "sstain",
                email = "dummy@gmail.com",
                password = "123fagsa",
                confirm = "123fagsa",
            };

            RegUser user2 = new RegUser()
            {
                id = 2,
                first_name = "Barasdnser",
                last_name = "sstaiasdn",
                email = "dummy@asdgmail.com",
                password = "123fagsa",
                confirm = "123fagsa",
            };

            RegUser user3 = new RegUser()
            {
                id = 3,
                first_name = "Barnasdser",
                last_name = "sstaasdin",
                email = "dumasdmy@gmail.com",
                password = "123fagsa",
                confirm = "123fagsa",
            };
            List<RegUser> users = new List<RegUser>();
            
            users.Add(user2);
            users.Add(user3);
            Wedding w1 = new Wedding()
            {
                id = 1,
                address = "Here",
                wedder_1 = "john",
                wedder_2 = "jessan",
                date = DateTime.Now,
                planner = user,
                guests = users,
            };
            Wedding w2 = new Wedding()
            {
                id = 2,
                address = "1Here",
                wedder_1 = "1john",
                wedder_2 = "1jessan",
                date = DateTime.Now,
                planner = user,
                guests = users,
            };
            Wedding w3 = new Wedding()
            {
                id = 3,
                address = "2Here",
                wedder_1 = "2john",
                wedder_2 = "2jessan",
                date = DateTime.Now,
                planner = user2,
                guests = users,
            };

            List<Wedding> weddings = new List<Wedding>();
            weddings.Add(w1);
            weddings.Add(w2);
            weddings.Add(w3);
            


            VM model = new VM()
            {
                _weddings = weddings,
                _reguser = user2,
            };
            // VM model = new VM()
            // {
            //     _weddings = _context.Weddings,
            //     _reguser = active,
            // };
            return View(model);
        }

        [HttpGet("Wedding/{id}")]
        public IActionResult Wedding(int id)
        {
            Wedding wedding = _context.Weddings.SingleOrDefault(w=>w.id == id);
            return View(wedding);
        }
    }
}
