public class Solution {
    public int Reverse(int x) {

        bool negative = false;
        if (x < 0)
        {
            if (x == int.MinValue)
                return 0;
            negative = true;
            x = -x;
        }

        int result = 0;
        
        while (x != 0)
        {
            int digit = x % 10;

            x = x / 10;

            if (result > int.MaxValue / 10)
                return 0;

            result = result * 10 + digit;
        }

        if (negative)
        {
            result = -result;
        }

        return result;
    }
}