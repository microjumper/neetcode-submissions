public class Solution
{

    public string Encode(IList<string> strs)
    {
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
        while(i < s.Length && s.IndexOf('#', i) != -1)
        {
            int p = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, p - i));
            string str = s.Substring(p + 1, length);
            decoded.Add(str);
            i += (p - i) + length + 1;
        }

        return decoded;
    }
}
