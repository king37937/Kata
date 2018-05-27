using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataHighestRankNumber
{
    public class Kata
    {
        public int HighestRank(int[] arr)
        {
            var list = new List<int>(arr);
            var result = list.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenByDescending(x => x.Key);

            return result.First().Key;
        }
    }
}
