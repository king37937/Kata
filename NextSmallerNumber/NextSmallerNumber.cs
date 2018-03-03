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

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                var largerNumberIndex = FindLargerNumberIndexFromTail(numbers, numbers[i], i);
                if (largerNumberIndex == i)
                {
                    continue;
                }
                Swap(numbers, largerNumberIndex, i);
                var sublist = numbers.GetRange(largerNumberIndex + 1, numbers.Count - largerNumberIndex -1);
                var largestNumberFromSublist = GetLargestGetNumber(sublist);
                var newNumbers = numbers.GetRange(0, largerNumberIndex + 1);
                newNumbers.AddRange(largestNumberFromSublist);
                if (newNumbers[0] == '0')
                {
                    return -1;
                }

                return int.Parse(string.Join("", newNumbers));
            }

            return -1;
        }

        private void Swap(List<char> list, int firstIndex, int secondIndex)
        {
            var tmp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = tmp;
        }

        private char[] GetLargestGetNumber(List<char> numbers)
        {
            return numbers.OrderByDescending(c => c).ToArray();
        }

        private int FindLargerNumberIndexFromTail(List<char> numbers, char baseNumber, int startIndex)
        {
            for (var i = startIndex; i >= 0; i--)
            {
                if (numbers[i] > baseNumber)
                {
                    return i;
                }
            }

            return numbers.IndexOf(baseNumber);
        }
    }
}

