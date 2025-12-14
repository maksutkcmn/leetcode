public class Solution {
    public int MaxArea(int[] height) {
        int maxWater = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < height.Length)
        {
            if (left >= right)
                return maxWater;
            int minWall = Math.Min(height[left], height[right]);

            int temp = minWall * (right - left);

            maxWater = Math.Max(temp, maxWater);

            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        
        return maxWater;
    }
}