public class Solution {
    public int FindNumbers(int[] nums) {
        int cnt = 0;
        for(int i = 0;i<nums.Length;i++){
            int len = getDigitsCount(nums[i]);
            if(len % 2 == 0) cnt++;
        }
        return cnt;
    }
    int getDigitsCount(int num){
        int len = 0;
        while(num > 0){
            len++;
            num /= 10;
        }
        return len;
    }
}