public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] indexes = new int[2];

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(i != j && nums[i] + nums[j] == target)
                {
                    indexes[0] = Math.Min(i, j);
                    indexes[1] = Math.Max(i, j);
                }
            }
        }

        return indexes;
    }
}
