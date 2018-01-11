using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter12_Exercises
{
    class Exercise4
    {
        public static void Run(string[] args)
        {
            const string END = "end";
            const string FILENAME = "FriendRecord.txt";
            string response = "";

            FileStream outFile = new FileStream("FriendRecord.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            while (response != END)
            {
                outFile.Seek(0, SeekOrigin.End);
                Friend friend = new Friend();
                Console.WriteLine("Friend's first name >> ");
                friend.FirstName = Console.ReadLine();
                Console.WriteLine("Friend's last name >> ");
                friend.LastName = Console.ReadLine();
                Console.WriteLine("Friend's phone number >> ");
                friend.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Month of friend's birthday >> ");
                friend.BirthdayMonth = Console.ReadLine();

                writer.WriteLine(friend.FirstName);
                writer.WriteLine(friend.LastName);
                writer.WriteLine(friend.PhoneNumber);
                writer.WriteLine(friend.BirthdayMonth);

                Console.WriteLine("Enter " + END + " to exit.");
                response = Console.ReadLine();
            }
            writer.Close();
            outFile.Close();
            
        }
    }
}
