using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferansTipleri
{
   internal class Araba
    {
      //fields (alanlar)
        //int id;
        public string marka;
        public string model;
        public string plaka;
        public int fiyat;
        public bool stokta = true;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Değişken Tipleri
            1. Değer Tipleri: Belleğin "stack" kısmında yaratılan ve bellek alanında doğrudan veriyi tutan değişken tipleridir.
               Her bir değer tipli değişken ayrı bir veri tutar. Birbirlerinden bağımsız kopyalardır.
               En çok kullanılan değer tipleri: int, double, byte, decimal, struct, enum, bool, char, short, long

            2. Referans Tipleri: Referans tipleri, kendilerine atanan verileri belleğin "heap" kısmında saklarlar ve "stack" kısmındaki
               alanlarında ise o verinin "heap" bölgesindeki adresini saklarlar.
               Yani içlerinde verinin kendisini değil, verinin bulunduğu yerine bellek adresini tutarlar.
               Bir referans tipi, başka bir referans tipine atandığında verisinin kopyası değil, bellek adresi atanmış olur ve
               her ikisi de aynı veriyi işaret eder. (Pointer) Aynı veri her 2 değişken tarafından da yönetilebilir.
               En çok kullanılan referans tipleri: class, delegate, interface, array(dizi), object, string(*)

            string(*): string referans tipli olmasına rağmen prtaikte kullanılırken değer tipli gibi davranır.
            
            */

            int a = 5;
            int b = 10;
            
            a = b;

            b = 50;

            Console.WriteLine($"a: {a} - b: {b}"); // a:10 - b:50

            string str1, str2;
            str1 = "Merhaba";
            str2 = "Dünya";

            str1 = str2;
            str2 = "Mars";

            Console.WriteLine($"str1: {str1} - str2: {str2}"); // str1:Dünya - str2:Mars

            /* Referans Tipleri
            class (sınıf): 
           
            */

            int[] intDizi1 = { 1, 2, 3 };
            int[] intDizi2 = { 4, 5, 6 };

            intDizi1 = intDizi2;

            intDizi1[0] = 100;

            for (int i = 0; i < intDizi2.Length; i++)
            {
                Console.WriteLine(intDizi2[i]);
            }

            Araba ferrari = new Araba();

            ferrari.



        }
    }
}
