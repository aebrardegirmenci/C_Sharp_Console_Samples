using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritanceAndPolymorphism1.Models
{
    internal class PDFDocument : Document
    {
        public PDFDocument()
        {
            
        }
        public PDFDocument(string fileName, string filePath, double fileSize)
        {
            FileName = fileName;
            FilePath = filePath;
            FileSize = fileSize;
            CreateDate = DateTime.Now;
        }
        public new void Print()
        {
            Console.WriteLine("{0} - Pdf Document has been printed.", FileName);
        }
        public new void Open()
        {
            Console.WriteLine("Pdf Document has been opened.");
        }
    }
}
