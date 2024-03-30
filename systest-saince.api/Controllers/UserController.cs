using Microsoft.AspNetCore.Mvc;
using systest_saince.api.ViewModels;
using systest_saince.repo.Services;

namespace systest_saince.api.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly IRegistrationRepo _registrationRepo;
        public UserController(IRegistrationRepo registrationRepo)
        {

            _registrationRepo = registrationRepo;
        }
        [HttpGet("user/index")]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost("user/AddUser")]
        public async Task<IActionResult> AddUser(UserRegistration userRegistration)
        {
            var result = await _registrationRepo.AddUser(userRegistration);
            return Ok(result);
        }
    }
}
