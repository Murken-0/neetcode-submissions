public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
            dict[target - nums[i]] = i;

        for (int i = 0; i < nums.Length; i++)
            if (dict.ContainsKey(nums[i]) && i != dict[nums[i]])
                return [Math.Min(i, dict[nums[i]]), Math.Max(i, dict[nums[i]])];
        return null;
    }
}