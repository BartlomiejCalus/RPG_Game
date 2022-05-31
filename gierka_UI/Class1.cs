using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gierka_UI
{

    public class Postać
    {
        protected string imie;

        bool widzenie_w_nocy;
        bool magia;
        bool tarcza;

        int wzrost;
        int waga;
        int wiek;

        string klasa;

        public int hp = 70;
        public int power = 50;
        public int intel = 50;
        public int agility = 50;

        public void podaj_imie(string a)
        {
            imie = a;
        }
        public string wyświetl_imie()
        {
            return imie;
        }



        public void podaj_umiejętności(bool a, bool b, bool c)
        {
            widzenie_w_nocy = a;
            magia = b;
            tarcza = c;
        }
        public bool wyświetl_widzenie_w_nocy()
        {
            return widzenie_w_nocy;
        }
        public bool wyświetl_magia()
        {
            return magia;
        }
        public bool wyświetl_tarcza()
        {
            return tarcza;
        }





        public void podaj_wygląd(int a, int b, int c, string d)
        {
            wzrost = a;
            waga = b;
            wiek = c;
            klasa = d;
        }
        public int wyświetl_wzrost()
        {
            return wzrost;
        }

        public int wyświetl_waga()
        {
            return waga;
        }

        public int wyświetl_wiek()
        {
            return wiek;
        }

        public string wyświetl_klasa()
        {
            return klasa;
        }

        public int wyświetl_wygląd()
        {
            return wzrost + waga + wiek;
        }

    }
}
