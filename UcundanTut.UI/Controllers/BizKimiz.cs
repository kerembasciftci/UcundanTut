using Microsoft.AspNetCore.Mvc;

namespace UcundanTut.UI.Controllers
{
    public class BizKimiz : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
