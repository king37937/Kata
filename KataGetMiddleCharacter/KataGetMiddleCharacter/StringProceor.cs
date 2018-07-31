using System;

namespace KataGetMiddleCharacter
{
    public class StringProceor
    {
        public string GetMiddle(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var middle = s.Length / 2;
            if (IsEven(s.Length))
            {
                return string.Join("", s[middle - 1], s[middle]);
            }
            else
            {
                return s[middle].ToString();
            }
        }

        private bool IsEven(int length)
        {
            return length % 2 == 0;
        }
    }
}
