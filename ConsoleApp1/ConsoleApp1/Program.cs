using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kosc
    {
        public static int licznik;

        public string[] obrazy = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png", };
        public int punkty;
        public int IDgraf;
        public bool czyDostepna;


        public Kosc(int liczbaOczek)
        {
            if (!(liczbaOczek >= 0 && liczbaOczek <= 6))
            {
                liczbaOczek = 0;
            }
            this.punkty = liczbaOczek;
            this.IDgraf = liczbaOczek;
            this.czyDostepna = true;
            licznik++;
        }
        public Kosc()
        {
            Random random = new Random();
            int los = random.Next(1,7);
            this.IDgraf = los;
            this.punkty = los;
            this.czyDostepna = true;
            licznik++;
        }
        public void losuj()
        {
            if (this.czyDostepna)
            {
                Random random = new Random();
                int los = random.Next(1, 7);
                this.IDgraf = los;
                this.punkty = los;
            }
        }
        public void blokuj()
        {
            this.czyDostepna = false;
        }
        public zwrotTekst()
        {
            switch (this.IDgraf)
            {
                case 1: return ("jeden");
                case 2: return ("dwa");
                case 3: return ("trzy");
                case 4: return ("cztery");
                case 5: return ("pięć");

            }
                

        }

    }
}
