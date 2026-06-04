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
        var buckets = new List<int>[nums.Length + 1];
        foreach (var key in dict.Keys)
        {
            if (buckets[dict[key]] == null)
                buckets[dict[key]] = new List<int>();
            buckets[dict[key]].Add(key);
        }

        int counter = 0;
        int[] result = new int[k];
        bool ended = false;
        for (int i = buckets.Length - 1; i >= 0; i--)
        {
            if (buckets[i] == null) continue;
            for (int j = 0; j < buckets[i].Count; j++)
            {
                result[counter++] = buckets[i][j];
                if (counter == k)
                {
                    ended = true; 
                    break;
                }
            }
            if (ended)
                break;
        }
        return result;
    }
}