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
    public class DernekManager : IDernekService
    {
        private readonly IDernekDal _dernekDal;
        public DernekManager(IDernekDal dernekDal)
        {
            _dernekDal = dernekDal;
        }
        public void Add(Dernek dernek)
        {
            _dernekDal.Add(dernek);
        }

        public void Delete(Dernek dernek)
        {
           _dernekDal.Delete(dernek);
        }

        public List<Dernek> GetAll()
        {
            return _dernekDal.GetAll();
        }

        public Dernek GetById(int id)
        {
            return _dernekDal.Get(x=>x.Id == id);   
        }

        public void Update(Dernek dernek)
        {
            _dernekDal.Update(dernek);
        }
    }
}
