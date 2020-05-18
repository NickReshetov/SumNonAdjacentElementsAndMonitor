using System;

namespace SumNonAdjacentElementsAndMonitor
{
    public class MaxSum
    {
        //
        //Time O(n), space O(1)
        //
        public int FindSum(int[] arr)
        {
            var twoElementsBackwardsSum = arr[0];
            var oneElementBackwardsSum = Math.Max(arr[0], arr[1]);

            switch (arr.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return twoElementsBackwardsSum;
                case 2:
                    return oneElementBackwardsSum;
            }

            var currentSum = 0;

            for (var i = 2; i < arr.Length; i++)
            {
                currentSum = Math.Max(arr[i] + twoElementsBackwardsSum, oneElementBackwardsSum);
                twoElementsBackwardsSum = oneElementBackwardsSum;
                oneElementBackwardsSum = currentSum;
            }

            return currentSum;
        }
    }
}
