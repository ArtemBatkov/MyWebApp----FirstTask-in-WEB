using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static TaskForm TaskFormVM = new TaskForm();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;            
        }

        public IActionResult Index()
        {
           
            return View();           
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

        public IActionResult Intro()
        {
            return View();
        }
        
        public IActionResult NewSection()
        {
            ViewData["Result"] = 0;
            return View(TaskFormVM);
        }
        
        
        [HttpPost]       
        
        public IActionResult NewSection(TaskForm tf)
        {
            int a = tf.input_1;
            int b = tf.input_2;
            int result = a  + b ;
            tf.output = result;
            ViewData["Result"] = tf.output;          
            return View();
        }
    }
}