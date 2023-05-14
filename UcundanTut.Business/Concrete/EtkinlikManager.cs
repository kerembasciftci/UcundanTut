using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Business.Abstract;
using UcundanTut.DataAccess.Abstract;
using UcundanTut.Entity.Concrete;

namespace UcundanTut.Business.Concrete
{
    public class EtkinlikManager : IEtkinlikService
    {
        private readonly IEtkinlikDal _etkinlikDal;
        public EtkinlikManager(IEtkinlikDal etkinlikDal)
        {
            _etkinlikDal = etkinlikDal;
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
