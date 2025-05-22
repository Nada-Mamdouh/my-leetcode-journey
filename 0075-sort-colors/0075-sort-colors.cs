public class Solution {
    public void SortColors(int[] nums) {
        int zerosCount = 0, onesCount = 0, twosCount = 0;
        for(int i = 0;i<nums.Length;i++){
            if(nums[i] == 0) zerosCount++;
            else if(nums[i] == 1) onesCount++;
            else twosCount++; 
        }
        for(int i = 0;i<nums.Length;i++){
            if(zerosCount > 0){
                nums[i] = 0;
                zerosCount--;
            }else if(onesCount > 0){
                nums[i] = 1;
                onesCount--;
            }else{
                nums[i] = 2;
                twosCount--;
            }
        }
    }
}