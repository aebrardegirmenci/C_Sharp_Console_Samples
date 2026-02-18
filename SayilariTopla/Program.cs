using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilariTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0, toplam = 0;
            Console.Write("1.sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());    

            Console.Write("2.sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama Sonucu: " + toplam);

            Console.ReadKey();  

        }
    }
}
