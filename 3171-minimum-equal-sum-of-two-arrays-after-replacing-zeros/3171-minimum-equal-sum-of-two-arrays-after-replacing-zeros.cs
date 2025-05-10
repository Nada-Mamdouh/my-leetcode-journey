public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        //TC: O(n+m)
        int zeros1 = 0, zeros2 = 0;
        long sum1 = 0, sum2 = 0;
        foreach(int num in nums1){
            sum1 += num;
            if(num == 0){
                zeros1++;
                sum1++;
            }
        }
        foreach(int num in nums2){
            sum2 += num;
            if(num == 0){
                zeros2++;
                sum2++;
            }
        }
        if((zeros1 == 0 && sum2 > sum1) || (zeros2 == 0 && sum1 > sum2)) return -1;
        return Math.Max(sum1, sum2);
    }
}