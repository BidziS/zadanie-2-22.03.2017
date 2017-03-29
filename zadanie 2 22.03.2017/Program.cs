using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_22._03._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwyklyTelefon zwyklyTelefon = new ZwyklyTelefon("Nokia");
            Smartphone smartphone = new Smartphone(zwyklyTelefon, "IPhone");
            Console.WriteLine(zwyklyTelefon.WybierzNumer("501123365"));
            Console.WriteLine(zwyklyTelefon.WyslijWiadomosc("Prosta wiadomość!"));
            zwyklyTelefon.PokazTyp();


            Console.WriteLine(smartphone.WybierzNumer("501123365"));
            Console.WriteLine(smartphone.WyslijWiadomosc("Prosta wiadomość!"));
            smartphone.PokazTyp();
            smartphone.OgladajFilmik();
            smartphone.GrajWGre();

            Console.ReadLine();
        }
    }
}
