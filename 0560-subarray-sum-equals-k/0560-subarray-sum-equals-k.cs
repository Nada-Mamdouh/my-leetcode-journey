public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int n = nums.Length, cnt = 0, pre = 0;
        Dictionary<int,int> dict = new();
        //dict.Add(0,1);
        for(int i = 0;i<n;i++){
           if(!dict.ContainsKey(pre)) dict.Add(pre,0);
           dict[pre]++;
           pre += nums[i];
           int val = pre - k;
           if(dict.ContainsKey(val)) cnt += dict[val];
        }

        return cnt;
    }
}