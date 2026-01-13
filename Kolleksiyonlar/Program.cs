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

            /*
             Generics: Jenerik koleksiyonlar
            
             Dictionary : Sözlük kolleksiyon tipi : İçerisine bir key ve bir value şeklinde çiftler halinde veriler girilen kolleksiyon tipidir.
             Dictionary<T key, T value> şeklinde Generik olarak tanımlanabilir.
             Key ve value için tip belirtilir ve girişler de belirttiğimiz tiplerde yapılabilir.
             Tip güvenlidir.
            
            */

            //    personeller.TryGetValue(123, out string isim); //123 anahtarına karşılık gelen değeri isim değişkenine atar.
            //contains
            //sum tolist
            //methodlar
            
            Dictionary<string,string> sozluk = new Dictionary<string, string>();

                        // key   //value
            sozluk.Add("apple", "elma");
            sozluk.Add("key", "anahtar");
            sozluk.Add("book", "kitap");
            sozluk.Add("notebook", "defter");
            sozluk.Add("tissue", "mendil");
            sozluk.Add("paper", "kağıt");
            sozluk.Add("school", "okul");

           // string arananKelime;

            Console.Write("İngilizce kelime giriniz: ");
            string arananKelime = Console.ReadLine();

            if (sozluk.ContainsKey(arananKelime))
            {
                Console.WriteLine("Aranan {0} kelimesinin Türkçe karşılığı : {1}",arananKelime, sozluk[arananKelime]);
                //Alternatif
                Console.WriteLine($"Aranan {arananKelime} kelimesinin Türkçe karşılığı : {sozluk[arananKelime]}");
            }
            else
            {
                Console.WriteLine("ASözlükte böyle bir ingilizce kelime bulunamadı.");
            }

            Console.WriteLine("---------------");

            Dictionary<int,string> personeller = new Dictionary<int, string>();

            personeller.Add(123, "Mahmut");
            personeller.Add(222, "Melahat");

            foreach (var personel in personeller)
            {
                Console.Write($"Sicil No: \"{personel.Key}\"\t - \t Ad: {personel.Value} \r\n"); // alt satıra indirme enter tuşu gibi
            }
            // ters bölü kullanmak için 2 tane kullanılmalı \\
            // \t 8 karakter boşluk ver 
            // tırnak basmak için \"

            //List: 

            Console.WriteLine("---------------");

            List<string> markalar = new List<string>();

            string ozelMarka = "Koeningseg";

            markalar.Add("Bmw");
            markalar.Add(123.ToString()); // liste içine string dışında bir şey eklemek istersek ToString ile stringe çeviririz.
            markalar.Add(ozelMarka);

            markalar.AddRange(sozluk.Keys.ToList());

            for (int i = 0; i < markalar.Count; i++)
            {
                Console.WriteLine(markalar[i]);
            }

            /*
            foreach (string marka in markalar)
            {
                Console.WriteLine(marka);
            }
            */

            //contains varsa yenisini eklememek için
            //remover

         // string liste =  markalar.Where(x => x.Contains("BMW")).FirstOrDefault(); // ilk bulduğunu döndür
                                                                                   //ToLİst();  liste döndürür
                                                  //Equals == yerine geçiyo
                                                 //Containsse içinde bmw içeren hepsi
                                       // (x => x == "BMW")) demekle aynı şey

            List<string> liste = markalar.Where(x => x.Contains("E60")).ToList();

            /*
             Listeden bir bilgiyi aramak ya da sorgulamak için Where sorgu metodu kullanılabilir.
             Where içerisinde Lambda "=>" işareti ile sorgulama yapılabilir.

            .Contains istediğimiz bir ifadeyi içeren tüm girdileri döndürür.

            .Equals istediğimiz değere eşit olan girdileri döndürür. 

            Sondaki .ToList() aradığımız kritere eşleşen tüm girdileri <T> generic tipinde liste olarak döndürür.
             */

          //  string liste2 = markalar.Where(x => x.Contains("BMW")).FirstOrDefault();
            string arananMarka = markalar.Where(x => x.Contains("B")).FirstOrDefault();

            /*
           Sondaki .FirstOrDefault() metodu aradığımız kriter ile eşleşen ilk kaydı döndürür.
            Ardığımız kritere uyan kayıt yok ise <T> nin default değerini döndürür.
             
             */

            markalar.Remove("123"); //belirttiğimiz değeri listeden siler
            // markalar.RemoveAt(2); //belirttiğimiz indeks numarasındaki elemanı siler.
            markalar.RemoveAt(markalar.Count-1);// sondaki elemanı siler

            markalar.Sort();// listeyi (alfabetik) sıralar
            markalar.Reverse();// listeyi tersine çevirir


            Console.ReadKey();

        }
    }
}
