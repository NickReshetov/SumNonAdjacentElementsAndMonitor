using System;

namespace SumNonAdjacentElementsAndMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"MaxSum{Environment.NewLine}");

            var maxSum = new MaxSum();
            var sum1 = maxSum.FindSum(new[] { 1, 2, 3, 1 });
            Console.WriteLine($"output: {sum1}");

            var sum2 = maxSum.FindSum(new[] { 2, 7, 9, 3, 1 });
            Console.WriteLine($"output: {sum2}");

            var sum3 = maxSum.FindSum(new[] { 5, 1, 2, 5 });
            Console.WriteLine($"output: {sum3}");
            Console.WriteLine();

            Console.WriteLine($"DeadPixels{Environment.NewLine}");

            var deadPixels = new DeadPixels();

            var screen1 = new [] 
            {
                new[] { '1', '0', '1' },
                new[] { '0', '1', '0' }, 
                new[] { '1', '0', '1' }
            };
            var deadPixelGroupsCount1 = deadPixels.CountGroups(screen1);
            Console.WriteLine($"output: {deadPixelGroupsCount1}");

            var screen2 = new []
            {
                new[] { '1', '1', '1' }, 
                new[] { '1', '0', '0' }, 
                new[] { '1', '0', '1' }
            };
            var deadPixelGroupsCount2 = deadPixels.CountGroups(screen2);
            Console.WriteLine($"output: {deadPixelGroupsCount2}");

            Console.ReadLine();
        }
    }
}
