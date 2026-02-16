using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
   abstract class Sekil
    {
        public abstract void AlanHesapla();

        public abstract void CevreHesapla();
    }

    class Ucgen : Sekil
    {
        public double Kenar1 { get; set; }
        public double Kenar2 { get; set; }
        public double Taban { get; set; }
        public double Yukseklik { get; set; }
        public override void AlanHesapla()
        {
            Console.WriteLine("Alanı: {0}", Yukseklik * Taban / 2);
        }
        public override void CevreHesapla()
        {
            Console.WriteLine("Çevresi: {0}", Kenar1 + Kenar2 + Taban);
        }
    }

    class Daire : Sekil
    {
        public double yariCap { get; set; }

        public override void AlanHesapla()
        {
            Console.WriteLine("Alanı: {0}", Math.PI * yariCap * yariCap);
        }

        public override void CevreHesapla()
        {
            Console.WriteLine("Çevresi: {0}", 2 * Math.PI * yariCap);
        }
    }

    class Dikdortgen : Sekil
    {
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }
        public override void AlanHesapla()
        {
            Console.WriteLine("Alanı: {0}", KisaKenar * UzunKenar);
        }

        public override void CevreHesapla()
        {
            Console.WriteLine("Çevresi: {0}", 2 * (KisaKenar + UzunKenar));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Object d11 = new Dikdortgen();
            Sekil daire = new Daire();

            Ucgen u1 = new Ucgen();
            u1.AlanHesapla();
            daire.AlanHesapla();
        }
    }
}
