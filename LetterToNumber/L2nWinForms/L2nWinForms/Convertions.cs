using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2nWinForms
{
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
