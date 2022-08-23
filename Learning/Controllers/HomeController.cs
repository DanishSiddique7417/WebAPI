using Learning.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WenRepository;
using WenRepository.Entity;

namespace Learning.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext con)
        {
           
            _context= con;
        }

        public IActionResult Index()

        {
            
            var obj = _context.tblUsers;


            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}