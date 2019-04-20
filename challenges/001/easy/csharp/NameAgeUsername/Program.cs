using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAgeUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            bool validInput = false;
            int age = 0;
            while (!validInput)
            {
                Console.WriteLine("Enter your age:");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0)
                    {
                        throw new Exception();
                    }
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("That's not a positive integer.  Try again.");
                }
            }

            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();

            string statement = $"Your name is {name}, your age is {age}, and your username is {username}.";

            // Extra Credit
            using (StreamWriter outputFile = new StreamWriter("info.txt"))
            {
                outputFile.WriteLine(statement);
            }

            Console.WriteLine(statement);
            Console.ReadKey();

        }
    }
}
