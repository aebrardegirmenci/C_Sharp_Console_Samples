using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Interfaces;

namespace OOP.Classes
{
    internal class Penguen : Kuslar, IYuzebilir
    {
        public string Yuz()
        {
         return "Penguen Yüzdü.";
        }
    }
}
