public class Solution
{
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            while (i < j && !Char.IsLetterOrDigit(s[i]))
            {
                i++;
            }

            while (i < j && !Char.IsLetterOrDigit(s[j]))
            {
                j--;
            }

            if (Char.ToUpperInvariant(s[i]) != Char.ToUpperInvariant(s[j]))
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
