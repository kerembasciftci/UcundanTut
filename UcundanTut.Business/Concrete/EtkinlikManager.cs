using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Business.Abstract;
using UcundanTut.DataAccess.Abstract;
using UcundanTut.Entity.Concrete;
using UcundanTut.Entity.DTOs;

namespace UcundanTut.Business.Concrete
{
    public class EtkinlikManager : IEtkinlikService
    {
        private readonly IEtkinlikDal _etkinlikDal;
        private readonly IDernekDal _dernekDal;
        public EtkinlikManager(IEtkinlikDal etkinlikDal, IDernekDal dernekDal)
        {
            _etkinlikDal = etkinlikDal;
            _dernekDal = dernekDal;
        }
        public void Add(Etkinlik etkinlik)
        {
            _etkinlikDal.Add(etkinlik);
        }

        public void Delete(Etkinlik etkinlik)
        {
            _etkinlikDal.Delete(etkinlik);
        }

        public List<Etkinlik> GetAll()
        {
            return _etkinlikDal.GetAll();
        }

        public List<EtkinlikDto> GetAllDto()
        {
            var query = from e in GetAll()
                        join d in _dernekDal.GetAll()
                        on e.DernekId equals d.Id
                        select new EtkinlikDto
                        {
                            Id = e.Id,
                            BaslangicZamani = e.BaslangicZamani,
                            EtkinlikAciklama = e.EtkinlikAciklama,
                            EtkinlikAd = e.EtkinlikAd,
                            EtkinlikMekan = e.EtkinlikMekan,
                            EtkinlikSehri = e.EtkinlikSehri,
                            BitisZamani = e.BitisZamani,
                            DernakAd = d.DernekAd,
                            DernekLogo = d.DernekLogo
                        };
            return query.ToList();
        }

        public Etkinlik GetById(int id)
        {
            return _etkinlikDal.Get(x => x.Id == id);
        }

        public void Update(Etkinlik etkinlik)
        {
            _etkinlikDal.Update(etkinlik);
        }
    }
}
