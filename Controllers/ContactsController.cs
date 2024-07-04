using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("IsValid");
                return Redirect("/");
            }
            Console.WriteLine("No way!");
            return View("Index");
        }
    }
}
