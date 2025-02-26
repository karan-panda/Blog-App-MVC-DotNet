using Microsoft.AspNetCore.Mvc;

namespace Blog_App.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
