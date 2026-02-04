using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
        private int hiz = 0; //kapsülleme
        public int maximumHiz = 190;

        //methods 
        public string Calistir()
        {
            return "Araba çalıştı.";
        }

        //Setter içerdeki bilgiye atamak
        public void Hizlan(int miktar)
        {
            hiz += miktar;

            if (hiz > maximumHiz)
            {
                hiz = maximumHiz;
            }
        }

        public void Yavasla(int miktar)
        {
            hiz -= miktar;

            if (hiz < 0)
            {
                hiz = 0;
            }
        }

        //GETTER disariya bilgi veren
        public int HizGoster()
        {
            return hiz;
        }
    }

    class Kus
    {
        //fields
        public string cinsi;
        public bool ucabilir = true;
        public bool yüzebilir = false;

        //methods - class içerisinde yaplacak işlemler
        public string SesCikar()
        {
            return "cik cik";
        }

        public string Beslen()
        {
            return "Kuş Beslendi.";
        }

        public void Yuz()
        {

        }
    }

    class Ogrenci
    {
        //field
        //propfull yaz
        private int ogrID;
        //property
        public int OgrID
        {
            get { return ogrID; }
            set { ogrID = value; }
        }

        //prop yaz özelleştirilmeyecekse
        public string AdSoyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }

        // public double DiplomaNotu { get; set; }

        private double diplomaNotu;

        public double DiplomaNotu
        {
            get { return diplomaNotu; }
            //set 
            //{
            //    if (value < 0)
            //        diplomaNotu = 0;
            //    else
            //        diplomaNotu = value; 
            //}
        }

        public double vizeNotu { get; set; }

        public double finalNotu { get; set; }

        public int Status { get; set; }

        public double NotGoster()
        {
            diplomaNotu = (vizeNotu * 0.4) + (finalNotu * 0.6);
            return (vizeNotu * 0.4) + (finalNotu * 0.6);
        }
    }

    internal class Urun
    {
        int urunID = 0; //alan - field

        public int UrunID { get; set; } //degiskenler kücük propertyler buyuk harfle

        public string Marka { get; set; } // özellik - property

        private double fiyat;

        public double Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value < 0)
                    fiyat = value * (-1);
                else
                    fiyat = value;
            }
        }

        public string BilgiVer()
        {
            return "Ürün ID:" + UrunID + " Marka:" + Marka + " Fiyat:" + Fiyat;
        }
    }
    enum Renkler
    {
        Siyah,
        Beyaz,
        Kırmızı,
        Mavi,
        Yeşil
    }

    enum ogrStatus
    {
        Aktif = 1,
        Kayıt_Dondurdu = 2,
        Disiplinde = 3,
        Mezun = 999
    }

    class Kitap
    {
        public string KitapAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public int YayinYili { get; set; }
        public double Fiyat { get; set; }
    }

    enum KitapKategorisi
    {
        Roman,
        Hikaye,
        Edebiyat,
        Bilim_Kurgu
    }

    interface ICanli
    {
        int ID { get; set; }
        string Name { get; set; }
        string Tur { get; set; }

        string Beslen(); //public-private yazılmaz.
        string Ure();
        string Dead();
    }

    interface IUcabilir
    {
        string Uc(); //methodun adı aynı olabilir parametrenin imzası aynı olamaz.
                     //string Uc(int irtifa);
                     //string Uc(int yukseklik, double surat);
                     //string Uc(int irtifa, int surat);
    }

    interface IYuzebilir
    {
        string Yuz();
    }
    //ctrl k d
    class Canli : ICanli //Implement exception - ctrl .
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tur { get; set; }

        public string Beslen()
        {
            return "Canlı beslendi.";
        }

        public string Dead()
        {
            return "Canlı öldü";
        }

        public string Ure()
        {
            return "Canlı üredi.";
        }
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

            Araba araba1 = new Araba();

            araba1.marka = "BMW";
            araba1.model = "E60";
            araba1.fiyat = 1700000;
            araba1.maximumHiz = 240;
            // araba1.hiz = 50;,
            araba1.Hizlan(25);
            araba1.Hizlan(15);
            araba1.Hizlan(25);
            araba1.Yavasla(10);

            Console.WriteLine("Araba1 in mevcut hızı: " + araba1.HizGoster());

            Araba araba2 = new Araba();

            araba2.marka = "Mercedes";
            araba2.model = "GT43";
            araba2.fiyat = 1500000;

            // araba1 = araba2; // araba1 de artık araba2 ile aynı hafıza alanını gösteriyor. araba1 in önceden atanan verilerinin bulunduğu alanın bağlantısı koptu. GC tarafından bu veriler yok edilecek.

            // araba1.fiyat = 3000000;

            // Console.WriteLine(araba2.fiyat);


            //ogr1.OgrID = -100;
            //Console.WriteLine(ogr1.OgrID);

            Ogrenci ogr1 = new Ogrenci();
            ogr1.AdSoyad = "ahmet";
            // ogr1.DiplomaNotu = 75;

            ogr1.vizeNotu = 58;
            ogr1.finalNotu = 85;
            ogr1.Status = (int)ogrStatus.Aktif;

            Console.WriteLine(ogr1.NotGoster());
            Console.WriteLine("ad: {0} vize notu: {1} final notu: {2} ortalama: {3}", ogr1.AdSoyad, ogr1.vizeNotu, ogr1.finalNotu, ogr1.DiplomaNotu);

            if (ogr1.DiplomaNotu >= 70 && ogr1.Status == (int)ogrStatus.Aktif)
                Console.WriteLine("Öğrenci mezun olabilir.");
            else
                Console.WriteLine("Öğrenci mezun olmak için uygun değildir.");



            /*
              a == true (&&) b == true ==> true
              a == true ve b == false ==> false
              a == false ve b == true ==> false
              a == false ve b == false ==> false

              a == true (||) b == true ==> true
              a == true ya da b == false ==> true
              a == false ya da b == true ==> true
              a == false ya da b == false ==> false
            */

            Console.WriteLine("---------------");

            Urun forma = new Urun();
            forma.Marka = "Adidas";
            forma.Fiyat = -4250;
            forma.UrunID = 5;

            //Console.WriteLine("Marka: {0} Fiyat: {1}", forma.Marka, forma.Fiyat);
            Console.WriteLine(forma.BilgiVer());

            string renk = "Kırmızı";
            // renk = Renkler.Kırmızı;

            int renkKodu = (int)Renkler.Kırmızı;

            Kitap Kitap1 = new Kitap()
            {
                KitapAdi = "Kitap1",
                SayfaSayisi = 250,
                YayinYili = 2020
            };

            Kitap Kitap2 = new Kitap()
            {
                KitapAdi = "Kitap2",
                SayfaSayisi = 300,
                YayinYili = 2018
            };

            Console.WriteLine(Kitap2.YayinYili);
        }
    }
}
