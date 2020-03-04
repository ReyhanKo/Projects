using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public class MasterConcreteBuilder:KrediKartiBuilder
    {
        public MasterConcreteBuilder()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Türkiye İş Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 8000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Gold";
        }

        public override void Taksit()
        {
            kart.Taksit = true;
        }
    }
}
