public class Solution {
    public int MinDeletionSize(string[] strs) {
        if (strs.Length == 0)
            return 0;

        int n = strs.Length;
        int m = strs[0].Length;
        int deletions = 0;

        bool[] sorted = new bool[n - 1];

        for (int col = 0; col < m; col++)
        {
            bool canKeep = true;

            for (int row = 0; row < n - 1; row++)
            {
                if (sorted[row])
                    continue;

                if (strs[row][col] > strs[row + 1][col])
                {
                    canKeep = false;
                    break;
                }
            }

            if (!canKeep)
            {
                deletions++;
            }
            else
            {
                for (int row = 0; row < n - 1; row++)
                {
                    if (strs[row][col] < strs[row + 1][col])
                    {
                        sorted[row] = true;
                    }
                }
            }
        }

        return deletions;
    }
}