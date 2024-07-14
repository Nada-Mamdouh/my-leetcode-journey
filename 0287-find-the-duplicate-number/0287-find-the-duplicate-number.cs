public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        int repeatedNum = 0;
        for(int i = 0;i<nums.Length;i++){
            if(numSet.Contains(nums[i])){
                repeatedNum = nums[i];
                break;
            }
            numSet.Add(nums[i]);
        }
        return repeatedNum;
    }
}