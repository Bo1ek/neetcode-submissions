public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCount = 0;
        int currentCount = 0;
        foreach (int num in nums)
        {
            currentCount = (num == 1) ? currentCount + 1 : 0;
            maxCount = Math.Max(maxCount, currentCount);
        }
        return maxCount;
    }
}