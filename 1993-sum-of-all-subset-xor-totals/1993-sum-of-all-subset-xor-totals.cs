public class Solution {
    int total = 0;
    public int SubsetXORSum(int[] nums) {
        Backtrack(ref nums, 0, 0);
        return total;
    }
    void Backtrack(ref int[] nums, int idx, int currentXor){
        if(idx == nums.Length){
            total += currentXor;
            return;
        }
        Backtrack(ref nums, idx + 1, currentXor ^ nums[idx]);
        Backtrack(ref nums, idx + 1, currentXor);
    }

}