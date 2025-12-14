public class Solution {
    public int MyAtoi(string s) {
        if (string.IsNullOrEmpty(s) || s.Length == 0)
            return 0;
        
        int negative = 1;
        int i = 0;
        int result = 0;

        while (i < s.Length && (s[i] == 32 || (s[i] >= 8 && s[i] <= 13)))
            i++;

        if (i < s.Length && (s[i] == '-' || s[i] == '+'))
        {
            negative = (s[i] == '-') ? -1 : 1;
            i++;
        }

        for (; i < s.Length; i++)
        {
            if (!(s[i] >= '0' && s[i] <= '9'))
                break;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && (s[i] - 48) > 7))
                return (negative == -1) ? int.MinValue : int.MaxValue;
            
            result = (result * 10) + (s[i] - 48);
        }

        return result * negative;
    }
}