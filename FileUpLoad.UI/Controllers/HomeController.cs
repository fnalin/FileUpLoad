using Microsoft.AspNetCore.Mvc;

namespace FileUpLoad.UI.Controllers
{
    public class HomeController:Controller
    {
        public string Teste() => "Bateu no HomeController";

        public IActionResult Index()
        {
            return View();
        }
        
    }
}
