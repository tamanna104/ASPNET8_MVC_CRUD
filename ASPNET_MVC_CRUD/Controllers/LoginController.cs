using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_CRUD.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
