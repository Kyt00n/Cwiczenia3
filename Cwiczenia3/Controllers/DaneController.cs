using Cwiczenia3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia3.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();
        }
        public IActionResult Wynik(Dane dane)
        {

            return View(dane);
        }
        public IActionResult Clear()
        {
            ModelState.Clear();
            return RedirectToAction("Form");
        }

    }
}
