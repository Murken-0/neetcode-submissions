public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var item in nums)
        {
            if (set.Contains(item))
                return true;
            set.Add(item);
        }
        return false;
    }
}