public class Solution {
    public long GetDescentPeriods(int[] prices) {
        if (prices.Length == 0) return 0;
        long result = prices.Length;

        int i = 0;
        while (i + 1 < prices.Length)
        {
            long period = 0;
            while (i + 1 < prices.Length && prices[i] - prices[i + 1] == 1)
            {
                period++;
                i++;
            }
            result += period * (period + 1) / 2;
            i++;
        }

        return result;
    }
}