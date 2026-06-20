public class Solution
{
    public int MaxArea(int[] heights)
    {
        int max = 0;

        int i = 0;
        int j = heights.Length - 1;

        while (i < j)
        {
            int lh = heights[i];
            int rh = heights[j];
            int area = (j - i) * Math.Min(lh, rh);
            
            max = Math.Max(max, area);

            if (lh <= rh)
            {
                do
                {
                    i++;
                }
                while (i < j && heights[i] <= lh);
            }
            else
            {
                do
                {
                    j--;
                }
                while (i < j && heights[j] <= rh);
            }
        }

        return max;
    }
}
