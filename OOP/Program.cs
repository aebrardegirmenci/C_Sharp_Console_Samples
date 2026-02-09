using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Classes;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım (Inheritance) : 

            Bitki gül = new Bitki();

            gül.Tur = Enums.Cinsiyet.Dişi;
            gül.Name = "Pembe Gül";

            Console.WriteLine(gül.Beslen());

            Hayvan inek = new Hayvan();

            inek.Tur = Enums.Cinsiyet.Dişi;
            inek.Name = "Holstein";

            Console.WriteLine(inek.Beslen());

            Ordek o1 = new Ordek();
            o1.KanatGenisligi = 70.4;
            Console.WriteLine(o1.Uc());

            //Polymorphism - Çok biçimlilik :

            Canli c = new Canli();

            Console.WriteLine("-------------");

            Console.WriteLine(c.Beslen(o1));
            Console.WriteLine(c.Beslen(gül));
            Console.WriteLine(c.Beslen(inek));

            Console.ReadKey();

        }
    }
}
