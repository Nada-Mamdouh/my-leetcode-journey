public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int numsLen = nums.Length;
        HashSet<int> numSet = new HashSet<int>();
        for(int i = 0;i<numsLen;i++){
            if(numSet.Contains(nums[i])) return true;
            numSet.Add(nums[i]);
        }
        return false;
    }
}