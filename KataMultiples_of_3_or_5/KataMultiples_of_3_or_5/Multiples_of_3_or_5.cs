using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMultiples_of_3_or_5
{
    public class Multiples_of_3_or_5
    {
        public int Sum(int n)
        {
            return GenerateList(n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }

        private IEnumerable<int> GenerateList(int n)
        {
            var list = Enumerable.Range(1, n - 1);
            foreach (var item in list)
            {
                yield return item;
            }
        }
    }
}
