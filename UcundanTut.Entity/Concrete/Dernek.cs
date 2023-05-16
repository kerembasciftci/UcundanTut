using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Core.Entity;

namespace UcundanTut.Entity.Concrete
{
    public class Dernek:IEntity
    {
        public int Id { get; set; }
        public string DernekAd { get; set; }
        public string DernekAciklama { get; set; }
        public string DernekMail { get; set; }
        public string DernekTelefon { get; set; }
        public ICollection<Etkinlik> Etkinlikler { get; set; }
        public string DernekLogo { get; set; }
    }
}
