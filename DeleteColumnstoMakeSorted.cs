public class Solution {
    public int MinDeletionSize(string[] strs) {
        if (strs.Length == 0)
            return 0;

        int result = 0;
        int columnLength = strs[0].Length;

        for (int i = 0; i < columnLength; i++)
        {
            bool incriese = false;
            for (int j = 0; j + 1 < strs.Length; j++)
            {
                if (strs[j + 1][i] < strs[j][i])
                {
                    incriese = true;
                    j = strs.Length;
                }
            }
            if (incriese)
                result++;
        }
        return result;
    }
}