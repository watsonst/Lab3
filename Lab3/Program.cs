using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your name?");
            string userName = Console.ReadLine();

 
                Console.Write($"{userName}, please enter an integer between 1 and 100: ");
                string integer = Console.ReadLine();
                int parsedInteger = int.Parse(integer);

                int remainder = parsedInteger % 2;

                if (parsedInteger < 1 || parsedInteger > 100)
                {
                    Console.WriteLine($"{userName}, {parsedInteger} is not an integer between 1 and 100.");
                }

                else if (remainder == 1)
                {
                    Console.WriteLine(parsedInteger + " Odd");
                }

                else if (remainder == 0 && (parsedInteger >= 2) && (parsedInteger <= 25))
                {
                    Console.WriteLine("Even and less than 25.");
                }

                else if (remainder == 0 && (parsedInteger >= 26) && (parsedInteger <= 60))
                {
                    Console.WriteLine("Even");
                }

                else if (remainder == 0 && parsedInteger > 60)
                {
                    Console.WriteLine(parsedInteger + " Even");
                }

                else if (remainder == 1 && parsedInteger > 60)
                {
                    Console.WriteLine(parsedInteger + " Odd");
                }

                Console.WriteLine($"{userName}, press any key to exit.");
                Console.ReadKey();

        }
    }
}

