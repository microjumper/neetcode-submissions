public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var sublists = new List<List<string>>();

        var anagramSublist = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new (chars);

            if (!anagramSublist.TryGetValue(key, out var list))
            {
                anagramSublist[key] = list = [];
            }
            list.Add(s);
        }

        foreach(var k in anagramSublist.Keys)
        {
            sublists.Add(anagramSublist[k]);
        } 

        return sublists;
    }
}
