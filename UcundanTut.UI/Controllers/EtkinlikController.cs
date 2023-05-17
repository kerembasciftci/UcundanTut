using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using UcundanTut.Business.Abstract;
using UcundanTut.Business.Concrete;
using UcundanTut.DataAccess.Abstract;
using UcundanTut.DataAccess.Concrete.EntityFramework;

namespace UcundanTut.UI.Controllers
{
    public class EtkinlikController : Controller
    {
        EtkinlikManager etkinlikManager = new EtkinlikManager(new EfEtkinlikDal(), new EfDernekDal());
        public ActionResult Index(string sehir)
        {
            var sehirler = etkinlikManager.GetAllBySehir(sehir);
            return View(sehirler);
        }

       
    }


}
