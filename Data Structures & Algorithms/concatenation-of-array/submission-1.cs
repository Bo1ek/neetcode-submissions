public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] newArray = new int[n*2];
        for ( int i =0; i < n; i++)
        {
            newArray[i] = newArray[i+n] = nums[i];
        }
        return newArray;
    }
}