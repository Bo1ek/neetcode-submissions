public class Solution {
    public int[] TwoSum(int[] nums, int target)     {
        var map = new Dictionary<int, int>();
        
        if (nums.Length <= 1)
            throw new ArgumentOutOfRangeException();
        
        for (var i = 0; i < nums.Length; i++)
        {
            var needed = target - nums[i];
            if(map.TryGetValue(needed, out var  j))
            {
                return new int[] {  j, i };
            }

            if (!map.ContainsKey(nums[i]))
                map[nums[i]] = i;
        }

        throw new InvalidOperationException("No two sum solution found.");
    }
}
