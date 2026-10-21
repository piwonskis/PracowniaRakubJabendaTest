using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Osoba
    {
        private int id { get; set; }
        private string name { get; set; }

        public static int instancesAmmount = 0;
        public Osoba()
        {
            instancesAmmount +=1;
            id = 0; 
            name = "";
        }
        public Osoba(int id, string name)
        {
            instancesAmmount +=1;
            this.id = id;
            this.name = name;
        }
        public Osoba(Osoba randomOsoba)
        {
            instancesAmmount +=1;
            this.id = randomOsoba.id;
            this.name = randomOsoba.name;
        }
        public void Witaj(string yourName)
        {
            if(string.IsNullOrEmpty(this.name))
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {this.name}, mam na imię {yourName}");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Osoba.instancesAmmount);
            Osoba osoba = new Osoba();
            Console.WriteLine(Osoba.instancesAmmount);
            Osoba osoba2 = new Osoba(2,"Jan");
            Osoba osoba3 = new Osoba(osoba2);
            osoba.Witaj("Adam");
            osoba2.Witaj("Adam");
            osoba3.Witaj("Adam");
            Console.WriteLine($"Liczba zarejestrowanych osob to {Osoba.instancesAmmount}");
        }
    }
}
