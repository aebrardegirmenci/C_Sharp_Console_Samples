using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Değişkenler");
            Console.WriteLine("----------------");

            /* Değer Tipli Değişken Tipleri:
            
            1. Metinsel veri tutan değişkenler:
            
            char, string
            char : tek karakter tutan değişken 
            string : karakter dizesi. birden fazla karakter içeren metin tutan değişken

            2. Sayısal veri tutan değişkenler:  
            
              a. Tam sayı değişkenler:
              byte, short, int, long
              byte : 1 byte lık değişken tipidir. 0-255 arası sayıları tutabilir.
              short : 2 byte lık değişken tipidir. -32.768 ile 32.767 arası tam sayıları tutabilir.
              int : 4 byte lık değişken tipidir. -2 milyar ile +2 milyar arası tam sayıları tutabilir.
              long : 8 byte lık değişken tipidir. -9, E+18 ile +9, E+18 arası tam sayıları tutabilir.
              
            NOT : F1 ile learn.microsoft.com dan yardım alabilirsiniz.

              b. Ondalıklı sayı tutan değişken tipleri:
              float, double, decimal
              
            date,time

            3. bool (Boolen-Mantıksal veri):
            true/false değerlerini tutan değişken tipidir.
               
                *scope : değişkenin geçerlilik alanı
            */

            byte vizeNotu = 50;

            int maas = 75000;

            double fiyat = 150.0;

            string userName;
            userName = "aleyna@xxx.com";

            int sayi1, sayi2, sonuc;

            sayi1 = 0; sayi2 = 0; sonuc = sayi1 + sayi2;

            double _fiyat, kdvOrani, kdvDahilFiyat;

            _fiyat = 158.75;
            kdvOrani = 0.2;
            kdvDahilFiyat = _fiyat * (1 + kdvOrani);

            char cevap = 'y';
            //char tipli veriler tek tırnak

            bool devamEdilsinMi;

            if (cevap == 'y')
            {
                devamEdilsinMi = true;
            }
            else 
            {
                devamEdilsinMi = false;


            }


        }
    }
}
