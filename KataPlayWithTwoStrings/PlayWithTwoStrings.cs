using System;
using System.Collections;
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
            for (int i = 0; i < stringA.Length; i++)
            {
                var index = stringB.IndexOf(stringA[i].ToString(), StringComparison.CurrentCultureIgnoreCase);
                if (index >= 0)
                {
                    stringB = ReverseCharCase(stringB, stringB[index]);
                }
            }

            for (int i = 0; i < stringB.Length; i++)
            {
                var index = stringA.IndexOf(stringB[i].ToString(), StringComparison.CurrentCultureIgnoreCase);
                if (index >= 0)
                {
                    stringA = ReverseCharCase(stringA, stringA[index]);
                }
            }

            return stringA + stringB;
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
