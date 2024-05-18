public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int len = nums.Length;
        int[] pre_sum = new int[len], suff_sum = new int[len];
        int p1 = 0, p2 = 0;
        for(int i = 0;i<len;i++){
            int j = 0;
            while(j<=i){
                pre_sum[i] +=nums[j];
                j++;
            }
        }
        
        for(int g = len-1;g >= 0;g--){
            int j = len-1;
            while(j>=g){
                suff_sum[g] +=nums[j];
                j--;
            }
        }
        while(p1 < len && p2 < len){
            if(pre_sum[p1] == suff_sum[p2] && p1 == p2) return p1;
            p1++;
            p2++;
        }
        return -1;
        
    }
}