using System;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            // With Yield 
            foreach (var item in data.RunningTotalWithYield())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            // General 
            foreach (var item in data.RunningTotal())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
