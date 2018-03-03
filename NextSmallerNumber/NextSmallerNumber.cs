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
            if (input >= 0 && input <= 9)
            {
                return -1;
            }

            var numbers = input.ToString().ToCharArray().ToList();
            var largerNumberIndex = FindLargerNumberIndex(numbers, numbers[numbers.Count - 1]);
            var subNumbers = numbers.GetRange(largerNumberIndex, numbers.Count - largerNumberIndex);
            var smallestNumber = GetSmallestNumber(subNumbers);
            var newNumbers = numbers.GetRange(0, largerNumberIndex);
            newNumbers.AddRange(smallestNumber);
            return int.Parse(string.Join("", newNumbers));
        }

        private char[] GetSmallestNumber(List<char> numbers)
        {
            return numbers.OrderBy(c => c).ToArray();
        }

        private int FindLargerNumberIndex(List<char> numbers, char baseNumber)
        {
            for (var i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > baseNumber)
                {
                    return i;
                }
            }

            return numbers.Count - 1;
        }
    }
}

