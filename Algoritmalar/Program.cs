using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya!");
            Console.WriteLine("----------------------");

            var Toplam = 5 + 8;

            Console.WriteLine("Toplam: " + Toplam);
            Console.WriteLine("----------------------");
            string kullaniciAd, durum;
            
            kullaniciAd = "Vedat ";

            Console.Write("Kullanıcı adınız: ");
            kullaniciAd = Console.ReadLine();

            Console.WriteLine("Hoşgeldin " + kullaniciAd);
            Console.Write("Nasılsın? İyi misin?");

            durum = Console.ReadLine();

            Console.WriteLine(durum + " yazdınız..");
            Console.WriteLine("----------------------");


            Console.ReadKey();

                
        }
    }
}
