using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataReverseWords
{
    public class Kata
    {
        public string ReverseWords(string words)
        {
            var tokens = words.Split(' ');
            var reversedTokens = tokens.Select(t => Reverse(t));
            return reversedTokens.Aggregate((prev, curr) => $"{prev} {curr}");
        }

        private string Reverse(string s)
        {
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
