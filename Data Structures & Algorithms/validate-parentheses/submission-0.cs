public class Solution
{
    private readonly Dictionary<char, char> closedToOpenBrackets = new()
    { 
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };
    
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach(char c in s)
        {
            if (closedToOpenBrackets.TryGetValue(c, out var open))
            {
                if (!stack.TryPop(out var p) || p != open)
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
