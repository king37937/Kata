﻿using System;
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
            var list = GetList(n, item => item % 3 == 0 || item % 5 == 0);
            return list.Sum();
        }

        private IEnumerable<int> GetList(int n, Func<int, bool> predicate)
        {
            var list = Enumerable.Range(1, n - 1);
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
