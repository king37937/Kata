using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFindMissingTerm
{
    public class FindMissingTerm
    {
        public int FindMissing(List<int> list)
        {
            var difference = FindConstantDifference(list);
            var expectValue = list[0];
            foreach (var term in list)
            {
                if (term != expectValue)
                {
                    return expectValue;
                }

                expectValue = term + difference;
            }

            return expectValue;
        }

        private int FindConstantDifference(List<int> list)
        {
            return Math.Min(list[1] - list[0], list[list.Count - 1] - list[list.Count - 2]);
        }
    }
}
