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

            if (s.Length % 2 == 0)
            {
                var middle = s.Length / 2;
                return "" + s[middle - 1] + s[middle];
            }
            else
            {
                var middle = s.Length / 2;
                return "" + s[middle];
            }
        }
    }
}
