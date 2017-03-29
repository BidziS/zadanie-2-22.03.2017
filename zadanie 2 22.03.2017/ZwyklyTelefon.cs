using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_22._03._2017
{
    public class ZwyklyTelefon:ITelefon
    {
        private string typ;

        public ZwyklyTelefon(string typ)
        {
            this.typ = typ;
        }

        public string WybierzNumer(string nrTelefonu)
        {
            Console.Write("Wybieram numer: ");
            return nrTelefonu;
        }

        public string WyslijWiadomosc(string wiadomosc)
        {
            Console.Write("Wysyłam wiadomość: ");
            return wiadomosc;
        }

        public string PokazTyp()
        {
            return typ;
        }
    }
}
