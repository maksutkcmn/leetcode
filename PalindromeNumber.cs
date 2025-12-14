public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversedHalf = 0;

        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + (x % 10);
            x = x / 10;
        }

        return (reversedHalf == x) || (x == reversedHalf / 10);
    }
}