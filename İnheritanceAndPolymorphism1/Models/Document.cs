using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceAndPolymorphism1.Models
{
    internal class Document
    {
        public Document() //ctor
        {
            CreateDate = DateTime.Now;  
        }
        public Document(string fileName, string filePath, double fileSize)
        {
            FileName = fileName;
            FilePath = filePath;
            FileSize = fileSize;
            CreateDate = DateTime.Now;
        }

        public string FileName { get; set; }
        public string FilePath { get; set; }
        public double FileSize { get; set; }
        public DateTime CreateDate { get; set; }

        public void Open()
        {
            Console.WriteLine("Document has been opened.");
        }
        public void Print()
        {
            Console.WriteLine("{0} Document has been printed.",FileName);
        }
        public void Delete()
        {
            Console.WriteLine("Document has been deleted.");
        }

    }
}
