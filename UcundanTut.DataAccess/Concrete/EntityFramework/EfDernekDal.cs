using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Core.DataAccess;
using UcundanTut.Core.DataAccess.EntityFramework;
using UcundanTut.DataAccess.Abstract;
using UcundanTut.Entity.Concrete;

namespace UcundanTut.DataAccess.Concrete.EntityFramework
{
    public class EfDernekDal : EfEntityRepository<Dernek,UcundanTutContext>,IDernekDal
    {
    }
}
