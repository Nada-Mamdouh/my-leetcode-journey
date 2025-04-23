public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        //Extreme brute force approach
        //TC: O(n^3)
        //SC: O(1)
        int countOfTriplets = 0;
        int n = nums.Length;
        for(int i = 0;i<n;i++){
            for(int j = i+1;j<n;j++){
                for(int k = j + 1;k<n;k++){
                    if(k > j && j > i){
                        int diff1 = nums[k] - nums[j];
                        int diff2 = nums[j] - nums[i];
                        if(diff1 == diff && diff2 == diff) {
                            countOfTriplets++;
                            break;
                        }
                    }
                }
            }
            
        }
        return countOfTriplets;
    }
}