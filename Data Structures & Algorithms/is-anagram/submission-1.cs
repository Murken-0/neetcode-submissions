public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

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