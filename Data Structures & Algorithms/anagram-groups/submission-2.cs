public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new List<List<string>>();
        foreach (var s in strs)
        {
            if (groups.Count == 0)
            {
                groups.Add([s]);
                continue;
            }

            bool added = false;
            foreach (var group in groups)
            {
                string t = group[0];

                if (IsAnagram(s, t))
                {
                    group.Add(s);
                    added = true;
                }
            }
            if (!added)
                groups.Add([s]);
        }
        return groups;
    }

    private bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        //if (s.Length == 0 && t.Length == 0) return true;
        var chars = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
            chars[t[i] - 'a']--;
        }
        foreach (var item in chars)
            if (item != 0)
                return false;
        return true;
    }
}