using System;
using System.Dynamic;
using System.Linq;

namespace TextWrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            var inputString = Console.ReadLine().Trim(' ');
            var words = inputString.Split(' ');

            while (words.Any(w => w.Length > 13))
            {
                Console.WriteLine("All words must be 13 characters or less.");
                Console.Write("Enter a string: ");
                inputString = Console.ReadLine().Trim(' ');
                words = inputString.Split(' ');
            }

            if (inputString.Length <= 13)
            {
                Console.WriteLine(inputString);
                Environment.Exit(0);
            }
       
            var returnString = "";

            for (var i = 0; i < words.Length;  i++)
             {              
                if (returnString.Length + 1 + words[i].Length <= 13)
                {
                    returnString = returnString + ' ' + words[i];
                    returnString = returnString.Trim(' ');

                    if (i == words.Length - 1)
                    {
                        Console.WriteLine(returnString);
                        Environment.Exit(0);
                    }
                    continue;
                }                              

                Console.WriteLine(returnString);
                returnString = words[i];

                if (i == words.Length - 1)
                {
                    Console.WriteLine(returnString);                    
                }
            }           
        }
    }
}
