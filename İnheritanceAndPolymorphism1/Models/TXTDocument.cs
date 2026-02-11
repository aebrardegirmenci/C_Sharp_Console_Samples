using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceAndPolymorphism1.Models
{
    internal class TXTDocument : Document
    {
        public new void Print()
        {
            Console.WriteLine("{0} - TXT Document has been printed.", FileName);
        }
        public new void Open()
        {
            Console.WriteLine("TXT Document has been opened.");
        }

    }
}
