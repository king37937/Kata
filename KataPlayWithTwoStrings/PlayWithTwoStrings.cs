using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPlayWithTwoStrings
{
    public class PlayWithTwoStrings
    {
        public string WorkOnStrings(string stringA, string stringB)
        {
            var reversedStringA = "";
            var reversedStringB = "";
            for (int i = 0; i < stringA.Length; i++)
            {
                if (stringB.Contains(stringA[i]))
                {
                    reversedStringB = ReverseCharCase(stringB, stringA[i]);
                }
            }

            for (int i = 0; i < stringB.Length; i++)
            {
                if (stringA.Contains(stringB[i]))
                {
                    reversedStringA = ReverseCharCase(stringA, stringB[i]);
                }
            }

            return reversedStringA + reversedStringB;
        }

        private string ReverseCharCase(string input, char c)
        {
            return input.Replace(c, InverseCase(c));
        }

        private char InverseCase(char c)
        {
            return (char) (c ^ 32);
        }
    }
}
