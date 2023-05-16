using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcundanTut.Entity.DTOs
{
    public class EtkinlikDto
    {
        public int Id { get; set; }
        public string DernakAd { get; set; }
        public string EtkinlikAd { get; set; }
        public string EtkinlikAciklama { get; set; }
        public DateTime BaslangicZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public string EtkinlikMekan { get; set; }
        public string EtkinlikSehri { get; set; }
        public string DernekLogo { get; set; }
    }
}
