public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (dictS.ContainsKey(c))
            {
                dictS[c]++;
            }
            else
            {
                dictS[c] = 1;
            }
        }

        foreach (var c in t)
        {
            if (dictT.ContainsKey(c))
            {
                dictT[c]++;
            }
            else
            {
                dictT[c] = 1;
            }
        }

        if (dictS.Count != dictT.Count) return false;

        foreach (var key in dictS.Keys)
        {
            if (!dictT.ContainsKey(key) || dictS[key] != dictT[key])
            {
                return false;
            }
        }
        return true;
    }
}