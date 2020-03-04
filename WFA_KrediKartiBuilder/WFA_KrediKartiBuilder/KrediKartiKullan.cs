using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public class KrediKartiKullan
    {
        public void KartKullan(KrediKartiBuilder kart)
        {
            kart.BankaAdi();
            kart.KartTipi();
            kart.KartLimit();
            kart.Taksit();
        }
    }
}
