public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int len = nums1.Length + nums2.Length;

        double[] ints = new double[len];

        int nums1point = 0;
        int nums2point = 0;

        for (int i = 0; i < len; i++)
        {
            if (nums1point >= nums1.Length)
            {

                ints[i] = nums2[nums2point];
                nums2point++;
            }
            else if (nums2point >= nums2.Length)
            {
                ints[i] = nums1[nums1point];
                nums1point++;
            }
            else if (nums1[nums1point] < nums2[nums2point])
            {
                ints[i] = nums1[nums1point];
                nums1point++;
            }
            else
            {
                ints[i] = nums2[nums2point];
                nums2point++;
            }
        }
        
        double response;

        if (len % 2 == 1)
        {
            response = ints[len / 2];
        }
        else
        {
            int res1 = (len - 1) / 2;
            int res2 = res1 + 1;
            response = (ints[res1] + ints[res2]) / 2;
        }
        return response;
    }
}