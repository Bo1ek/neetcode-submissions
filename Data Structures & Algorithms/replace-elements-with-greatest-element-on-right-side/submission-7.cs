public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxRight =-1;
        int n = arr.Length;
        int[] ans = new int[n];
        for (int i = n-1; i>=0;i--)
        {
            ans[i] = maxRight;
            maxRight = Math.Max(arr[i], maxRight);
        }
        return ans;
    }
}