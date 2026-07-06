public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxSub = nums[0];
        var currSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (currSum < 0)
                currSum = 0;
            currSum += nums[i];
            maxSub = Math.Max(currSum, maxSub);
        }

        return maxSub;
    }
}
