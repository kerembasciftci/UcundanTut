using Microsoft.AspNetCore.Mvc;
using UcundanTut.Business.Concrete;
using UcundanTut.DataAccess.Concrete.EntityFramework;

namespace UcundanTut.UI.Controllers
{
    public class EtkinlikController : Controller
    {
        EtkinlikManager etkinlikManager = new EtkinlikManager(new EfEtkinlikDal());
        public IActionResult Index()
        {
            var etkinlikler = etkinlikManager.GetAll();
            return View(etkinlikler);
        }
    }
}
