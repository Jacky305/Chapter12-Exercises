using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Chapter12_Exercises
{
    class Exercise4b
    {
        public static void Run(string[] args)
        {
            const string END = "end";
            const char DELIM = '\n';
            const string FILENAME = "FriendRecord.txt";

            string recordIn;
            string response;

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            inFile.Seek(0, SeekOrigin.Begin);
            recordIn = reader.ReadLine();

            Console.WriteLine("Enter friend's first name >> ");
            response = Console.ReadLine();

            while (recordIn != null)
            {
                if (recordIn == response)
                {
                    Console.WriteLine(recordIn);
                    recordIn = reader.ReadLine();

                    Console.WriteLine(recordIn);
                    recordIn = reader.ReadLine();

                    Console.WriteLine(recordIn);
                    recordIn = reader.ReadLine();

                    Console.WriteLine(recordIn);
                    recordIn = reader.ReadLine();
                }
                //Console.WriteLine(recordIn);
                recordIn = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
        }
    }
}
