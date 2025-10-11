public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
       IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(nums);
        int n = nums.Length;
        
        for(int i = 0;i<n;i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            
            
            int j = i + 1;
            int k = n - 1;
            while(j < k){
                int total = nums[i] + nums[j] + nums[k];
                if(total < 0) j++;
                else if(total > 0) k--;
                else{
                    ans.Add(new List<int>{nums[i],nums[j],nums[k]});
                    j++;
                    k--;
                    while(j < k && nums[j] == nums[j-1]) j++;
                    while(j < k && nums[k] == nums[k+1]) k--;
                }
            }
        }
        
        
        
        
        return ans;
    }
}