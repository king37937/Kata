﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextSmallerNumber
{
    public class NextSmallerNumber
    {
        public long FindNext(long input)
        {
            var numbers = input.ToString().ToCharArray().ToList();
            
            for (var i = numbers.Count - 1; i >= 0; i--)
            {
                var largerNumberIndex = FindLargerNumberIndexFromTail(numbers, i);
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

                return long.Parse(string.Join("", newNumbers));
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

        private int FindLargerNumberIndexFromTail(List<char> numbers, int startIndex)
        {
            for (var i = startIndex; i >= 0; i--)
            {
                if (numbers[i] > numbers[startIndex])
                {
                    return i;
                }
            }

            return startIndex;
        }
    }
}

