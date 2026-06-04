public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (int x in nums)
        {
            if (!dict.ContainsKey(x))
                dict[x] = 1;
            else 
                dict[x]++;
        }

        return dict.Keys
            .OrderByDescending(key => dict[key])
            .Take(k)
            .ToArray();
    }
}