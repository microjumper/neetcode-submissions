public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] indexes = [-1, -1];

        var visited = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int n = target - nums[i];

            if(visited.ContainsKey(n))
            {
                indexes[0] = visited[n];
                indexes[1] = i;

                break;
            }
            else
            {
                visited[nums[i]] = i;
            }
        }

        return indexes;
    }
}
