public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s == null || t == null || s.Length != t.Length)
        {
            return false;
        }

        int[] letterCount = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            int key = s[i] - 'a';
            letterCount[key] += 1;
        }

        for(int i = 0; i < t.Length; i++)
        {
            int key = t[i] - 'a';
            letterCount[key] -= 1;

            if(letterCount[key] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
