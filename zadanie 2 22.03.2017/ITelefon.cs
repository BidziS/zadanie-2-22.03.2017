using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_22._03._2017
{
    public interface ITelefon
    {
        string WybierzNumer(string nrTelefonu);

        string WyslijWiadomosc(string wiadomosc);

        string PokazTyp();


    }
}
