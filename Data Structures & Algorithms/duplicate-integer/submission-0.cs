public class Solution
{
    public bool hasDuplicate(int[] nums)
    {    
        var dictionary = new Dictionary<int, bool>();

        foreach(var n in nums)
        { 
            var wasAdded = dictionary.TryAdd(n, true);

            if(!wasAdded) 
            { 
                return true;
            }
        }

        return false;
    }
}