public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] pes = new int[nums.Length];

        pes[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            pes[i] = nums[i - 1] * pes[i - 1];
        }

        int runningProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            pes[i] *= runningProduct;
            runningProduct *= nums[i];
        }

        return pes;
    }
}
