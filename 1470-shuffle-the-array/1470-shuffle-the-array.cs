public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] answer = new int[2 * n];
        for(int g = 0, i = 0,j = n; 
            i < nums.Length && g<nums.Length && j < nums.Length;
            g++,i+=2,j++){
            answer[i] = nums[g];
            answer[i+1] = nums[j];
        }
        return answer;
    }
}