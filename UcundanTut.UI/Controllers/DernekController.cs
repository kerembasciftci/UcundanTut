using Microsoft.AspNetCore.Mvc;
using UcundanTut.Business.Concrete;
using UcundanTut.DataAccess.Concrete.EntityFramework;

namespace UcundanTut.UI.Controllers
{
    public class DernekController : Controller
    {
        DernekManager dernekManager = new DernekManager(new EfDernekDal());
        public IActionResult Index()
        {
            var dernekler = dernekManager.GetAll();
            return View(dernekler);
        }
    }
}
