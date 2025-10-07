public class Solution {
    public int MajorityElement(int[] nums) {
        int n = nums.Length, maxCnt = 0, majority = 0;
        var dict = new Dictionary<int,int>();
        for(int i = 0;i<n;i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],0);
            }
            dict[nums[i]]++;
        }
        foreach(var item in dict){
            if(item.Value > maxCnt){
                maxCnt = item.Value;
                majority = item.Key;
            }
        }
        return majority;
    }
}