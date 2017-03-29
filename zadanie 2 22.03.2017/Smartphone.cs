using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_22._03._2017
{
    public class Smartphone:Dekorator
    {
        public Smartphone(ZwyklyTelefon iTelefon, string typ)
            : base(iTelefon, typ)
        {

        }
        public void OgladajFilmik()
        {
            Console.WriteLine("Oglądam filmik");          
        }
        public void GrajWGre()
        {
            Console.WriteLine("Gram w gierkę");
        }
    }
}
