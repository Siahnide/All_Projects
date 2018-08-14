using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Wall.Controllers
{
    public class HomeController : Controller
    {
        private WallContext _context;
        public RegUser active {get{return _context.users.SingleOrDefault(user => user.id == HttpContext.Session.GetInt32("active"));}}
        
        
        
        public HomeController(WallContext context)
        {
            _context = context;
            
        }
       

        public IActionResult Index()
        {    
            return View();
        }

        [HttpPost("Reg")]
        public IActionResult Register(RegUser _user){
            HttpContext.Session.Clear();
            if(ModelState.IsValid)
            {
                
                _context.Add(_user);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("active",_user.id);
                return RedirectToAction("Wall",active);
            }    
            return View("Index");
        }

        [HttpPost("Login")]
        public IActionResult Login(LogUser _user){
            HttpContext.Session.Clear();
            if(ModelState.IsValid)
            {
                RegUser ruser = _context.users.SingleOrDefault(user => user.email == _user.email);
                if(_user.password == ruser.password)
                {
                        HttpContext.Session.SetInt32("active",ruser.id);
                        return RedirectToAction("Wall",active);
                }
            }
            return View("Login");
        }
        [HttpGet("Log")]
        public IActionResult Log()
        {
            return View("Login");
        }
        [HttpGet("Wall")]
        public IActionResult Wall(RegUser user)
        {
            
            

            VM model = new VM()
            {
                Reg = _context.users.SingleOrDefault(u => u.id ==  active.id),
                posts = _context.posts.Include(posts =>posts._user).Include(posts=>posts.comments).ThenInclude(c=>c._user),
                comments = _context.comments.Include(comment=> comment._user).Include(Comment=>Comment._post),
            };

            return View(model);
        }

        [HttpPost("CreatePost")]
        public IActionResult Create_Post(VM model)
        {
            model.post._userid = active.id;
            _context.Add(model.post);
            _context.SaveChanges();
            return RedirectToAction("Wall");
        }
        [HttpPost("CreateComment")]
        public IActionResult Create_Comment(VM model)
        {
            model.comment._userid =active.id;
            _context.Add(model.comment);
            _context.SaveChanges();
            return RedirectToAction("Wall");
        }

    }
}
