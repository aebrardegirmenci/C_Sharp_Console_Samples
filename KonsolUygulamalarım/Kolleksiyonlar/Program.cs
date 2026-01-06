using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

             Kolleksiyonlar:
            İçerisinde birden fazla değer taşıyabilen değişken tiplerine kolleksiyon denir.
            Bazı kolleksiyonlar tek tip veriler taşıyabiliyorken, bazı kolleksiyonlar ise farklı tiplerden verileri içinde taşıyabilir.
            İçinde tek tip veri tutanlara Tip güvenli (type safe) kolleksiyon denir.
            Farklı tiplerde veri tutabilenler ise Tip güvenli değildir.

             Bazı kolleksiyon tipleri:
            Array, ArrayList, Dictionary, List

            Array: içinde aynı tipten veriler tutar. 
            örnek: 
           
            */

            string ad = "Ali";
                   ad = "Veli";

            string[] adlar = new string [6];
            adlar[0] = "Ali";
            adlar[1] = "Berrin";
            adlar[2] = "Murat";
            adlar[5] = "Cemile";

            Console.WriteLine(adlar[0]);

            Console.WriteLine("---------------");

            int[] not = {12345, 56789, 4567, 1234, 9632};

            string[] plakalar = { "34ABC34", "35aaa111", "10ON10", "16BRS16"};

            Console.WriteLine(plakalar[0]);

            Console.WriteLine("---------------");

            for (int i = 0; i < plakalar.Length; i++)
            {
                Console.WriteLine(plakalar[i]);
            }

            Console.WriteLine("---------------");

            foreach (string plaka in plakalar)
            {
                Console.WriteLine(plaka);
            }

            string[] newAdlar = new string[10];

            adlar.CopyTo(newAdlar, 0);

            // Array.Copy(adlar, newAdlar, adlar.Length);

            // Array.Clear(adlar, 0, adlar.Length); 

            // adlar = null; --> gereksiz bilgilerin atılması için null kullanılır.

            newAdlar[7] = "Ali Kemal";
            newAdlar[9] = "Narin";

            Array.Sort(newAdlar);
                                   //üstteki alfabetik sıralama altaki indeks nosunu tersine çevirmek için yani tam tersi sırayla yazılır.
            Array.Reverse(newAdlar);

            Console.WriteLine("---------------");

            foreach (string item in newAdlar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();





        }
    }
}
