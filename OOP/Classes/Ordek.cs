using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Interfaces;

namespace OOP.Classes
{
    internal class Ordek : Kuslar, IYuzebilir, IUçabilir
    {
        public string Uc()
        {
            return "Ördek Uçtu";
        }

        // abstract, virtual, override calis.

        public string Yuz()
        {
            return "Ördek Yüzdü";

        }
        public new string Beslen()
        {
            return "Ördek beslendi.";
        }

    }
}
   
  