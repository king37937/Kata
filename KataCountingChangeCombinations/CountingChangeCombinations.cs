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
            var orderedCoins = coins.OrderBy(x => x).ToList();

            var combination = FindCombination(money, orderedCoins, 0);

            return combination;
        }

        private static int FindCombination(int money, List<int> coins, int index)
        {
            //find a conbination
            if (money == 0)
            {
                return 1;
            }

            if (money < 0 || index == coins.Count)
            {
                return 0;
            }

            var firstCoin = FindCombination(money - coins[index], coins, index);
            var remainCoin = FindCombination(money, coins, index + 1);

            return firstCoin + remainCoin;
        }
    }
}
