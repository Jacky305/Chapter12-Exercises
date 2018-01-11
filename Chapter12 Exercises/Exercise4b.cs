using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            inFile.Seek(0, SeekOrigin.Begin);
            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                Console.WriteLine(recordIn);
                recordIn = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
        }
    }
}
