namespace SumNonAdjacentElementsAndMonitor
{
    public class DeadPixels
    {
        //
        //Time O(width*height), space O(1)
        //
        public int CountGroups(char[][] monitor)
        {
            var damagedPixelGroupsCount = 0;

            if (monitor.Length == 0)
            {
                return 0;
            }

            int width = monitor.Length;
            int height = monitor[0].Length;

            for (int col = 0; col < width; col++)
            {
                for (int row = 0; row < height; row++)
                {
                    char element = monitor[col][row];

                    if (element == '1')
                    {
                        DFS(monitor, col, row);
                        damagedPixelGroupsCount++;
                    }
                }
            }

            return damagedPixelGroupsCount;
        }

        private void DFS(char[][] monitor, int col, int row)
        {
            int width = monitor.Length;
            int height = monitor[0].Length;

            if (col >= 0 && col < width && row >= 0 && row < height && monitor[col][row] == '1')
            {
                monitor[col][row] = '0';

                DFS(monitor, col + 1, row); //right
                DFS(monitor, col - 1, row); //left
                DFS(monitor, col, row + 1); //below
                DFS(monitor, col, row - 1); //above
            }
        }
    }
}
