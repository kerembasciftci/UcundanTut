using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcundanTut.Core.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcundanTut.Entity.Concrete
{
    public class Etkinlik:IEntity
    {
        public int Id { get; set; }
        public int DernekId { get; set; }
        public string EtkinlikAd { get; set; }
        public string EtkinlikAciklama { get; set; }
        public DateTime BaslangicZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public string EtkinlikMekan { get; set; }
        public string EtkinlikSehri { get; set; }
        public bool AktifMi { get; set; }
    }
}
