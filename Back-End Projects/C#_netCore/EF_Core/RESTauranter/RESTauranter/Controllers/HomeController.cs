using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTauranter.Models;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private RESTContext _context;
        public HomeController(RESTContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult AddRev(Review rev)
        {
            _context.Add(rev);
            _context.SaveChanges();
            return RedirectToAction("Reviews");
        }
        public IActionResult Reviews()
        {
            List<Review> allreviews = _context.reviews.ToList();
            RevModel model = new RevModel()
            {
                reviews = allreviews
            };
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
