using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daty
{
    class Wynik
    {
        public DateTime data;
        public TimeSpan span;
        public int typ;

        public Wynik()
        {
            data = new DateTime();
            span = new TimeSpan();
            typ = -1;
        }

        public void Wypisz()
        {
            string wynik;

            switch(typ)
            {
                case 1:
                    wynik = data.ToString();
                    break;
                case 2:
                    wynik = data.ToString();
                    wynik = wynik.Replace('.', '-');
                    break;
                case 3:
                    wynik = data.ToString();
                    wynik = wynik.Replace('.', '/');
                    break;
                case 4:
                    wynik = data.ToString();
                    wynik = wynik.Replace('.', ',');
                    break;
                case 5:
                    wynik = span.ToString();
                    break;
                default:
                    wynik = "Blad";
                    break;
            }
            Console.WriteLine(wynik);
        }
    }
}
