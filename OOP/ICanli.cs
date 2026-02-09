using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OOP.Enums;
// using HesapMakinesi; //References'tan eklenmeli.

namespace OOP
{
    internal interface ICanli
    {
      //  HesapMakinesi.Program // yukarıya using yazarsak buna gerek kalmıyor.

        string Name { get; set; }
        Enums.Cinsiyet Tur { get; set; }

        string Beslen();
        string Ure();
        string Dead();

    }
}
