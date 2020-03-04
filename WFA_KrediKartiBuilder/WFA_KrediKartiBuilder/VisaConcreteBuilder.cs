using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public class VisaConcreteBuilder : KrediKartiBuilder
    {
        public VisaConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 12000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Bonus";
        }

        public override void Taksit()
        {
            kart.Taksit = true;
        }
    }
}
