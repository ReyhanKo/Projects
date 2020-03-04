using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KrediKartiBuilder
{
    class Program
    {
        
        static void Main(string[] args)
        {
            KrediKartiBuilder gercekKart = new AmericaExpressConcreteBuilder();
            KrediKartiKullan kullan = new KrediKartiKullan();
            kullan.KartKullan(gercekKart);

            Console.WriteLine(gercekKart.Kart.ToString());
            Console.Read();
        }
    }
}
