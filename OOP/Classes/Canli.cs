using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Enums;

namespace OOP.Classes
{
    internal class Canli : ICanli
    {
        public string Name { get; set ; }
        public Cinsiyet Tur { get ; set ; }

        public string Beslen()
        {
            return "Canlı beslendi.";
        }

        public string Dead()
        {
            return "Canlı öldü.";
        }

        public string Ure()
        {
            return "Canlı üredi.";
        }

        public string Beslen(Canli c)
        {
            return c.GetType().ToString() + " " + c.Name + " " + c.Tur.ToString() + " beslendi.";
        }

    }
}
