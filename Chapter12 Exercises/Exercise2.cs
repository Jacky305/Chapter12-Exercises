using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Chapter12_Exercises
{
    class Exercise2
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Size of file 1:");
            if(File.Exists("Quote.txt"))
            {
                FileInfo info = new FileInfo("Quote.txt");
                Console.WriteLine(info.Length+"kb");
            }

            Console.WriteLine("Size of file 2:");
            if (File.Exists("Quote.docx"))
            {
                FileInfo info = new FileInfo("Quote.docx");
                Console.WriteLine(info.Length+"kb");
            }
        }
    }
}
