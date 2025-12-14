public class Solution {

    public bool Helper(string s, string p, int sIndex, int pIndex)
    {
        if (pIndex == p.Length)
            return sIndex == s.Length;

        bool firstMach = (sIndex < s.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '.'));

        if (pIndex + 1 < p.Length && p[pIndex + 1] == '*')
        {
            return Helper(s, p, sIndex, pIndex + 2) ||
                (firstMach && Helper(s, p, sIndex + 1, pIndex));
        }
        
        return firstMach && Helper(s, p, sIndex + 1, pIndex + 1);
    }

    public bool IsMatch(string s, string p) {
        if (string.IsNullOrEmpty(p))
            return string.IsNullOrEmpty(s);

        return Helper(s, p, 0, 0);
    }
}