using System;
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
            else
            {
                var digits = input.ToString().ToCharArray();
                var temp = digits[0];
                digits[0] = digits[1];
                digits[1] = temp;
                return int.Parse(new string(digits));
            }
        }
    }
}
