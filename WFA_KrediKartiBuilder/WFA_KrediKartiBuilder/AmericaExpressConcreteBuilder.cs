using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartiBuilder
{
    public class AmericaExpressConcreteBuilder : KrediKartiBuilder
    {
       
        public AmericaExpressConcreteBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 20000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Apex";
        }

        public override void Taksit()
        {
            kart.Taksit = false;
        }
    }
}
