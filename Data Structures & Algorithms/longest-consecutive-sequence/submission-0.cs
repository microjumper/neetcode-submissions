public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int longestSequence = 0;
        
        var elements = new HashSet<int>(nums);

        foreach (var e in elements)
        {
            if (elements.Contains(e - 1))
            {
                continue;
            }

            int startingElement = e;
            int sequenceLength = 1;
            while(elements.Contains(startingElement + 1))
            {
                startingElement++;
                sequenceLength++;
            }

            longestSequence = Math.Max(sequenceLength, longestSequence);
        }

        return longestSequence;
    }
}
