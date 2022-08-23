using Microsoft.AspNetCore.Mvc;
using WenRepository;

namespace Learning.Controllers
{
    public class DanishController : Controller
    {
        public readonly IConfiguration configuration;
        public readonly ApplicationContext cont;
        public DanishController(IConfiguration con, ApplicationContext _cont)
        { 
        configuration = con;
            cont = _cont;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Getdata")]
        public ActionResult GetData()
        {
            var obj = cont.tblUsers;
            return View(obj);
        }
    }
}
