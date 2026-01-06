using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatörler kodlama esnasında kullandığımız özel işaretlerdir. İşlem yaparken kullanılırlar. 

            // Operatör türleri:

            // 1) Aritmetik Operatörler:    +,-,*,/

            // 2) Karşılaştırma Operatörleri: ==, ===, <, <=, >, >=, !=
            /* 
             "==" eşitlik kontrol eder. her 2 tarafına yazılan ifade birbirine eşitse "true", değilse "false" sonucunu üretir. 
                örnek: (sayi == 0)
             
             "!=" 2 tarafına yazılan ifadeleri karşılaştırır. ve bu ifadeler birbirine eşit değilse "true" döndürür. yani "==" in tersidir.
                örnek: (sayi != 0) sayı 0 dan farklıysa demektir.
              
             "<, <=, >, >=" işaretleri 2 taraflarına yazılan değerlerin birbirinden küçük ya da büyük olup olmadıklarını karşılaştırır.
              sonuca göre "true" ya da "false" döner. 
                örnek: (sayi <= 0) sayı 0 dan küçük ya da eşitse demektir.
             
             "===" 2 değerin birbirine hem değer olarak hem de tip olarak eşit olup olmadığını denetler.
                örnek: (sayi === 0)
                
                örnek: int sayi1 = 0;
                       double sayi2 = 0;
                       if(sayi1 = sayi2) --> true
                
                örnek: if(sayi1 === sayi2) --> false çünkü tipleri farklıdır.        
            */
            // 3) Atama Operatörü: "=" sağına yazılan değeri, soluna yazılan nesneye aktarır.
            // örnek: (sayi1 = 0)

            // 4) İşlem Kısaltma Operatörleri: (Birleşik İşlem Operatörleri) +=, -=, *=, /=, ++, --, **, %
            /*
             "+=" sağına yazılan değeri, soldaki nesnenin değerine ekler.
                örnek: (sayi1 += 50) sayi1 in değerini 50 arttır demektir. kısaltmasız hali: (sayi1 = sayi1 + 50)
             
             "-=" değer eksiltir.
                örnek: (sayi1 -= 50) sayi1 in değerini 50 azalt demektir. kısaltmasız hali: (sayi1 = sayi1 - 50)

             "*=" çarparak arttır.
                örnek: (sayi1 *= 3) sayi1 in değerini 3 ile çarp demektir. 

             "/=" değeri bölerek aktarır.
                örnek: (sayi1 /= 3) sayi1 in değerini 3 e böl demektir.
             
             "++" soldaki nesnenin değerini 1 arttırır.

             "--" soldaki nesnenin değerini 1 eksiltir.

             "**" soldaki nesnenin değerini kendisi ile çarpar.

             "%" mod alma işlemi yapar. soldaki değerin, sağdaki değere bölümünden kalan değeri verir.
               örnek: (5 % 2 = 1) 5 in 2 ye bölümünden kalan 1 dir.
             */

            int sayi1 = 5;
            int sayi2 = 10;
           
            double dblSonuc;
            bool boolSonuc;

            boolSonuc = sayi1 == sayi2;
            Console.WriteLine(boolSonuc);
            Console.WriteLine(sayi1 == sayi2);

            sayi2 *= sayi1;
            Console.WriteLine(sayi2);

            sayi1++;
            sayi1 += sayi1;

            Console.WriteLine(sayi1);

            Console.WriteLine(sayi2 % sayi1);



        }
    }
}
