public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;

        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int left = 0;
        int maxLength = 0;

        for(int right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];

            if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= left)
            {
                left = charIndexMap[currentChar] + 1;
            }

            charIndexMap[currentChar] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}