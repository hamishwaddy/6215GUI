using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.Instruction);
            string word = Console.ReadLine();

            Console.WriteLine(Messages.StringBreak(word));
            Console.WriteLine(Messages.StringTotal(word));

            Console.ReadLine();
        }
    }

    class Messages
    {
        public static string Instruction = "Type in a word";

        public static string StringBreak(string word)
        {
            return $"\nBreakup of the word {word} is \n{Convertions.StringBreak(word)}\n";
        }

        public static string StringTotal(string word)
        {
            return $"{word} has a score of {Convertions.StringTotal(word)} %";
        }
    }

    class Convertions
    {
        public static string StringBreak(string word)
        {
            string breakup = "";

            foreach (char number in word)
            {
                int index = char.ToUpper(number) - 64;
                breakup += $"{number} is {index}\n";
            }

            return breakup;
        }

        public static int StringTotal(string word)
        {
            int total = 0;

            foreach (char number in word)
            {
                int index = char.ToUpper(number) - 64;
                total += index;
            }

            return total;
        }
    }
}
            

           
    

