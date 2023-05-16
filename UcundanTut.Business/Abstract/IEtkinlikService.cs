using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Entity.Concrete;
using UcundanTut.Entity.DTOs;

namespace UcundanTut.Business.Abstract
{
    public interface IEtkinlikService
    {
        public void Add(Etkinlik etkinlik);
        public void Delete(Etkinlik etkinlik);
        public void Update(Etkinlik etkinlik);
        public List<Etkinlik> GetAll();
        public Etkinlik GetById(int id);
        public List<EtkinlikDto> GetAllDto();
    }
}
