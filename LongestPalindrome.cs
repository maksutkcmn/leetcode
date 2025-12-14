public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return "";
        
        int resultStart = 0;
        int resultEnd = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            int[] pos1 = ExpandAroundCenter(s, i, i);

            int[] pos2 = ExpandAroundCenter(s, i, i + 1);

            int len1 = pos1[1] - pos1[0] + 1;
            int len2 = pos2[1] - pos2[0] + 1;
            
            int[] longest = len1 > len2 ? pos1 : pos2;

            int currentLen = longest[1] - longest[0] + 1;
            int maxLen = resultEnd - resultStart + 1;
            
            if (currentLen > maxLen)
            {
                resultStart = longest[0];
                resultEnd = longest[1];
            }
        }
        
        int length = resultEnd - resultStart + 1;
        return s.Substring(resultStart, length);
    }
    
    private int[] ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        left++;
        right--;
        
        return new int[] { left, right };
    }
}