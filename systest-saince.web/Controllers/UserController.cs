using Microsoft.AspNetCore.Mvc;
using Systemtest_saince.Models;

namespace Systemtest_saince.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            UserRegistrationModel model = new UserRegistrationModel();
            //model.Addresses.Add(new Address { City = })
            //model.Addresses.
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateUser(UserRegistrationModel userRegistrationModel)
        { 
        return View(userRegistrationModel);
        }


    }
}
