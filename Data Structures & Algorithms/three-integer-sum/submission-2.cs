public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var triplets = new List<List<int>>();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }

            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int t = nums[i] + nums[j] + nums[k];

                if (t < 0)
                {
                    j++;
                    continue;
                }

                if (t > 0)
                {
                    k--;
                    continue;
                }

                triplets.Add([nums[i], nums[k], nums[j]]);

                while (j < k && nums[j] == nums[j + 1])
                {
                    j++;
                }
                
                while (j < k && nums[k] == nums[k - 1])
                {
                    k--;
                }

                j++;
                k--;
            }
        }

        return triplets;
    }
}
