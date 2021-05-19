using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
    public class Data
    {
        List<int> lstNums;
        public Data()
        {
            lstNums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        }
        public IEnumerable<int> RunningTotalWithYield()
        {
            int total = 0;
            foreach (var num in lstNums)
            {
                total += num;
                yield return (total);
            }
        }
        public IEnumerable<int> RunningTotal()
        {
            List<int> runningTotal = new List<int>(); int total = 0;
            foreach (var num in lstNums)
            {
                total += num;
                runningTotal.Add(total);
            }
            return runningTotal;
        }
    }
}
