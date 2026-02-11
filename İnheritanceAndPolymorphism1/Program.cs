using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using İnheritanceAndPolymorphism1.Models;

namespace İnheritanceAndPolymorphism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document d1 = new Document();

            d1.FileName = "Test.Txt";
            d1.FilePath = "c:\\users\\werwe\\";
            //d1.CreateDate = DateTime.Now;
            d1.FileSize = 100000;

            Document d2 = new Document("abc.pdf", "c:\\users\\fdfs\\ttt.pdf", 12500);

            PDFDocument pdf1 = new PDFDocument();
            PDFDocument pdf2 = new PDFDocument("dfsdf.pdf", "c:\\users\\sdfsd\\",35000);

            WordDocument word1 = new WordDocument();
            word1.FileName = "engagement.docx";

           /* double sayi1=0, sayi2, sonuc;
            sayi2 = Math.PI;
            Console.WriteLine(sayi2);
           */

            d1.Print();
            d2.Print();
            pdf1.Print();
            pdf2.Print();
            word1.Print();


        }
    }
}
