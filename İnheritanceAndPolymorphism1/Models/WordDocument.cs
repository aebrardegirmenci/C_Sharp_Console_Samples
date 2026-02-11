using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceAndPolymorphism1.Models
{
    internal class WordDocument : Document
    {
        public new void Print()
        {
            Console.WriteLine("{0} - Word Document has been printed.", FileName);
        }
        public new void Open()
        {
            Console.WriteLine("Word Document Document has been opened.");
        }
    }
}
