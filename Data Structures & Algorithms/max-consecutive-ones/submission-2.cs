public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int count = 0;

        foreach (int n in nums)
        {
            count = (count + 1) * n;
            
            if (count > max) 
            {
                max = count;
            }
        }

        return max;
    }
}