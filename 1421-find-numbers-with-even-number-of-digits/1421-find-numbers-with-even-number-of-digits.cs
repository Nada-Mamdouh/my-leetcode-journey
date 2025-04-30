public class Solution {
    public int FindNumbers(int[] nums) {
        int cnt = 0;
        for(int i = 0;i<nums.Length;i++){
            if(hasEvenDigits(nums[i])) cnt++;
        }
        return cnt;
    }
    bool hasEvenDigits(int num){
        int digits = 0;
        while(num > 0){
            digits++;
            num /= 10;
        }
        return ((digits & 1) == 0);
    }
}