using FrontEnd.Data;
using Microsoft.AspNetCore.Mvc;

namespace HDDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepo;
        public HomeController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult GetAllUsers()
        {
            var users = _userRepo.GetAllUsers();
            return Ok(users);
        }
        // public string GetAllUsers()
        // {
            
        //     return "Get All User";

        // }

    }
}
