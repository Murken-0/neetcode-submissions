public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            if (!groups.ContainsKey(GetKey(s)))
                groups[GetKey(s)] = new List<string>();
            groups[GetKey(s)].Add(s);
        }
        return groups.Keys.Select(k => groups[k]).ToList();
    }

    private string GetKey(string s)
    {
        var chars = new int[26];
        for (int i = 0; i < s.Length; i++)
            chars[s[i] - 'a']++;
        return string.Join('-', chars);
    }
}