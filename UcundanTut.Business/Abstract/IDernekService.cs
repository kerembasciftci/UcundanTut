using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Entity.Concrete;

namespace UcundanTut.Business.Abstract
{
    public interface IDernekService
    {
        public void Add(Dernek dernek);
        public void Delete(Dernek dernek);
        public void Update(Dernek dernek);
        public List<Dernek> GetAll();
        public Dernek GetById(int id);
    }
}
