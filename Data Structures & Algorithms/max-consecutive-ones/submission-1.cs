public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int count = 0;

        foreach (int n in nums)
        {
            if (n == 1)
            {
                count++;
            }
            else
            {
                max = Math.Max(max, count);
                count = 0;
            }
        }

        return Math.Max(max, count);
    }
}