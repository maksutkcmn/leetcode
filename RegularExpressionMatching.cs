public class Solution {

    //For optimization (like cache)
    Dictionary<(int, int), bool> memoization;

    public bool Helper(string s, string p, int sIndex, int pIndex)
    {
        if (memoization.ContainsKey((sIndex, pIndex)))
            return memoization[(sIndex, pIndex)];

        if (pIndex == p.Length)
        {
            bool result = sIndex == s.Length; 
            memoization[(sIndex, pIndex)] = result;
            return result;
        }

        bool firstMach = (sIndex < s.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '.'));

        bool answer;

        if (pIndex + 1 < p.Length && p[pIndex + 1] == '*')
        {
            answer = Helper(s, p, sIndex, pIndex + 2) ||
                (firstMach && Helper(s, p, sIndex + 1, pIndex));
        }
        else
        {
            answer = firstMach && Helper(s, p, sIndex + 1, pIndex + 1);            
        }
        
        memoization[(sIndex, pIndex)] = answer;

        return answer;
    }

    public bool IsMatch(string s, string p) {
        if (string.IsNullOrEmpty(p))
            return string.IsNullOrEmpty(s);
        memoization = new Dictionary<(int, int), bool>();
        return Helper(s, p, 0, 0);
    }
}