public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(k==0)
            return false;

        HashSet<int> window = new HashSet<int>();

        for(var R=0; R<nums.Length; R++)
        {
            if(!window.Add(nums[R]))
                return true;
        
            if(window.Count > k)
                window.Remove(nums[R-k]);
        }

        return false;

    }
}