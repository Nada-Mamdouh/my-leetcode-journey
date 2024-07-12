public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        for(int i = 0;i<nums.Length;i++){
            numSet.Add(nums[i]);
        }
        for(int j = 0;j<=nums.Length;j++){
            if(!numSet.Contains(j)){
                return j;
            }
        }
        return -1;
    }
}