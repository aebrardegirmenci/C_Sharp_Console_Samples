using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc;
            string _operator;

 tekrar:

            Console.Write("1. sayıyı giriniz: ");
            // sayi1 = Convert.ToDouble(Console.ReadLine());
            try
            {
                sayi1 = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz." + ex.Message);
                goto tekrar;
            }

 tekrar2: 

            // string olarak gelen bilgiyi double tipteki değişkene aktarabilmek için tip dönüşümü yapmak gerekiyor.

            Console.Write("2. sayıyı giriniz: ");

            try
            {
                sayi2 = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz." + ex.Message);
                goto tekrar2;
            }
            // sayi1 = Convert.ToDouble(Console.ReadLine());

islemSec:
           
            Console.WriteLine("[+] Toplama");
            Console.WriteLine("[-] Toplama");
            Console.WriteLine("[*] Toplama");
            Console.WriteLine("[/] Toplama");
            Console.Write("İşlem Seçiniz: ");

            _operator = Console.ReadLine();
            
            if(_operator == "+")
            {
                // karşılaştırma sonucu doğru (true) ise çalışacak kod
                sonuc = sayi1 + sayi2;

            }
            else if (_operator == "-")
            {
              sonuc = sayi1 - sayi2;
            }
            else if (_operator == "*")
            {
              sonuc = sayi1 * sayi2;
            }
            else if (_operator == "/")
            {
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    sonuc = 0;
                }
            }
            else
            {
                sonuc = 0;
                Console.WriteLine("Lütfen geçerli bir işlem seçerek tekrar deneyiniz.");
                goto islemSec;
            }

            Console.WriteLine(sayi1+_operator+sayi2+"="+sonuc);

            Console.ReadKey();

            Console.Clear();
            sayi1 = 0;
            sayi2 = 0;
            sonuc = 0;
            _operator = "";
            goto tekrar;
        }
    }
}
