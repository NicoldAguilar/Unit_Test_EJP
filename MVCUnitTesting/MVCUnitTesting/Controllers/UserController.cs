using Microsoft.AspNetCore.Mvc;

namespace MVCUnitTesting.Controllers
{
    public class UserController : Controller
    {
        private DbEntities context;
        public UserController(DbEntities context)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = ContextBoundObject.Users.ToList();
            return View(users);
        }
    }
}
