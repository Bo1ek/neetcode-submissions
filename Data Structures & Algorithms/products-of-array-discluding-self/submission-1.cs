public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums is null || nums.Length == 0)
            throw new ArgumentException("nums must not be empty");
        
        var n = nums.Length;
        var answer = new int[n];

        var leftProduct = 1;

        for (var i = 0; i < n; i++)
        {
            answer[i] = leftProduct;
            leftProduct *= nums[i];
        }

        var rightProduct = 1;

        for (var i = n - 1; i >= 0; i--)
        {
            answer[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return answer;
    }
}
