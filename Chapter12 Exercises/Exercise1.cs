using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter12_Exercises
{
    class Exercise1
    {
        public static void Run(string[] args)
        {
            const string END = "end";
            string temp = "";
           
            while(temp != "end")
            {
                Console.WriteLine("Enter folder name >> ");
                temp = Console.ReadLine();

                if(Directory.Exists(temp))
                {
                    Console.WriteLine("{0}", Directory.GetCreationTime(temp));
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }
            }
        }
    }
}
