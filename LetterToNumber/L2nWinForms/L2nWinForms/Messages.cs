using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2nWinForms
{
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
    
}
