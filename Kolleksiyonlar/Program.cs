using System;
using System.Collections;
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

            Console.WriteLine("--- Array ---");

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

            Console.WriteLine("---------------");
            Console.WriteLine("--- ArrayList ---");

            //ARRAYLIST: İçine object tipinde veri kabul edilen kolleksiyondur. Tip güvenli değildir. 
            ArrayList list = new ArrayList();

            //nesne örneği alma demek.

            list.Add("Çay");
            list.Add("Kahve");
            list.Add(25);
            list.Add(DateTime.Now);
            list.Add(true);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");

            for (int i = 0; i < list.Count; i++)  //nesne olursa length değil count kullanılır.
            {
                Console.WriteLine(list[i]);
            }

            /* if (list.Contains("Kahve"))
             {
                 Console.WriteLine("Kahve var");
             }
             else
             {
                 Console.WriteLine("Kahve yok");
             }
            */

            //  list.Contains("Kahve"); //içeriyor mu?

            if(list.Contains("Kahve"))
                Console.WriteLine("Listede kahve mevcut"); //süslü parantezi ifin veya elsein içi tek satırsa kullanmaya gerek yok
            else
                Console.WriteLine("Listede kahve mevcut değil.");

            list.RemoveAt(list.IndexOf(true)); //içine sayı yazılırsa indeks(sıra) numarasına göre siler. yazıysa direkt onu siler.

            list.Remove("Çay"); //nesne silmek istiyosan

            Console.WriteLine("---------------");

            for (int i = 0; i < list.Count; i++)  //nesne olursa length değil count kullanılır.
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("--- Hashtable ---");

            Hashtable hashListe = new Hashtable(); //Dictionary ile aynı işi yapar. bunda tip güvenli değildir.

            hashListe.Add(100, "armut");
            hashListe.Add(300, "elma");

            Hashtable gunler = new Hashtable();
            //key anahtar value
            //öncekinden farkı her bir item tek değerdi 

            gunler.Add("Pzt", "Pazartesi");
            gunler.Add("Sal", "Sali");
            gunler.Add("Crş", "Carsamba");
            gunler.Add("Prs", "Persembe");
            gunler.Add("Cuma", "Cuma");
            gunler.Add("Cmt", "Cumartesi");
            gunler.Add("Pzr", "Pazar");

            Console.WriteLine(gunler["Sal"]);
            Console.WriteLine("---------------");

            /* for (int i = 0; i < gunler.Count; i++)
             {

             }
            */

            foreach (var item in gunler.Keys) //keyleri yazdırır
            {
                Console.WriteLine(gunler[item]);
            }

            Console.WriteLine("---------------");
            Console.WriteLine(hashListe[100]); // 100 keyine karşılık gelen değeri yazdırır.

            Console.WriteLine("Lütfen ekrana kısa adını yazınız: ");
            string aranan = Console.ReadLine();

            if (gunler.ContainsKey(aranan))
                Console.WriteLine(gunler[aranan]);
            else
                Console.WriteLine("Aranan gün bulunamadı.");
            

            Console.WriteLine("---------------");
            Console.WriteLine("--- Dictionary ---");

            // Dictionary: Tip güvenli kolleksiyondur.

            Dictionary<string,string> sozluk = new Dictionary<string, string>();

            sozluk.Add("apple", "elma");
            sozluk.Add("key", "anahtar");
            sozluk.Add("book", "kitap");


            Console.ReadKey();

        }
    }
}
