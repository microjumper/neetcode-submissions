public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var sublists = new List<List<string>>();

        var anagramSublist = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            var letters = s.ToCharArray();
            Array.Sort(letters);
            string key = new (letters);

            if(anagramSublist.ContainsKey(key))
            {
                anagramSublist[key].Add(s);
            }
            else
            {
                anagramSublist[key] = [s];
            }
        }

        foreach(var k in anagramSublist.Keys)
        {
            sublists.Add(anagramSublist[k]);
        } 

        return sublists;
    }
}
