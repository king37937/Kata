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
            stringA = stringA.ReverseSameCharCaseWith(stringB);
            stringB = stringB.ReverseSameCharCaseWith(stringA);
            
            return stringA + stringB;
        }
    }

    public static class StringExtensions
    {
        public static string ReverseSameCharCaseWith(this string baseStr, string target)
        {
            var ignoreList = new List<char>();
            foreach (var c in baseStr)
            {
                var sameCharCount = GetCharCount(target, c);
                if (sameCharCount % 2 == 1 && !ignoreList.Contains(c))
                {
                    baseStr = baseStr.Replace(c, ReverseCase(c));
                }

                ignoreList.Add(c);
            }

            return baseStr;
        }

        private static int GetCharCount(string searchFrom, char match)
        {
            return searchFrom.Count(c => c == match || ReverseCase(c) == match);
        }

        private static char ReverseCase(char c)
        {
            return (char)(c^32);
        }
    }
}
