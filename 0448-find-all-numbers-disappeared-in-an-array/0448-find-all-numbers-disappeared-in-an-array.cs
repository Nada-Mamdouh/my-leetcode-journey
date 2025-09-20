public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        int maxValue = 0, minValue = int.MaxValue;
        List<int> ans = new List<int>();
        for(int i = 0;i<n;i++){
            if(nums[i] > maxValue) maxValue = nums[i];
            if(nums[i] < minValue) minValue = nums[i];
        }
        HashSet<int> sett = new HashSet<int>();
        for(int i = 0;i<n;i++){
            if(!sett.Contains(nums[i])) sett.Add(nums[i]);
        }
        if(maxValue < n){
            //check logic here 
            for(int i = 1;i<=n;i++){
                if(!sett.Contains(i)) ans.Add(i);
            }
        }else{
            //check logic here 
            for(int i = 1;i<=maxValue;i++){
                if(!sett.Contains(i)) ans.Add(i);
            }
        }
        
        return ans;
    }
}