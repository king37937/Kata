using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCountingChangeCombinations
{
    public class CountingChangeCombinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            int changeTimes = 0;
            var orderedCoins = coins.OrderByDescending(x => x).ToList();
            var remainMoney = money - orderedCoins[0];
            if (remainMoney - orderedCoins[1] == 0)
            {
                changeTimes++;
            }

            return changeTimes;
        }
    }
}
