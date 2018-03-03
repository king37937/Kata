using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextSmallerNumber
{
    public class NextSmallerNumber
    {
        public int FindNext(int input)
        {
            var numbers = input.ToString().ToCharArray().ToList();
            if (numbers.Count == 1)
            {
                return -1;
            }

            var largerNumberIndex = FindLargerNumberIndexFromTail(numbers, numbers[numbers.Count - 1]);
            var smallestNumber = GetSmallestNumber(numbers.GetRange(largerNumberIndex, numbers.Count - largerNumberIndex));
            var newNumbers = numbers.GetRange(0, largerNumberIndex);
            newNumbers.AddRange(smallestNumber);
            return int.Parse(string.Join("", newNumbers));
        }

        private char[] GetSmallestNumber(List<char> numbers)
        {
            return numbers.OrderBy(c => c).ToArray();
        }

        private int FindLargerNumberIndexFromTail(List<char> numbers, char baseNumber)
        {
            for (var i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > baseNumber)
                {
                    return i;
                }
            }

            return numbers.Count-1;
        }
    }
}

