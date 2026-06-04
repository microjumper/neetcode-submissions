public class Solution
{

    public string Encode(IList<string> strs)
    {
        if (strs == null || strs.Count == 0)
        {
            return string.Empty;
        }

        var encoded = new StringBuilder();

        foreach(var s in strs)
        {
            encoded.Append($"{s.Length}#{s}");
        }

        return encoded.ToString();
    }

    public List<string> Decode(string s)
    {
        var decoded = new List<string>();

        int i = 0;
        while(i < s.Length)
        {
            int delimiterIndex = s.IndexOf('#', i);
            
            int length = int.Parse(s.Substring(i, delimiterIndex - i));
            
            i = delimiterIndex + 1;

            string str = s.Substring(i, length);
            decoded.Add(str);

            i += length;
        }

        return decoded;
    }
}
