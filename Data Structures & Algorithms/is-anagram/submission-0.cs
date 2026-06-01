public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        var letters = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(letters.ContainsKey(s[i]))
            {
                letters[s[i]] += 1;
            }
            else
            {
                letters[s[i]] = 1;
            }
        }

        for(int i = 0; i < t.Length; i++)
        {
            if(letters.ContainsKey(t[i]))
            {
                letters[t[i]] -= 1;

                if(letters[t[i]] < 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
