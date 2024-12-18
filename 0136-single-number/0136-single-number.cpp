class Solution {
public:
    int singleNumber(vector<int>& nums) {
       //Brute force
       //TC: O(n*n) sc: O(1)
       int n = nums.size(),ans = 0, count = 0;
       for(int i = 0;i<n;i++){
           count = 0;
           for(int j = 0;j<n;j++){
               if(nums[i] == nums[j]){
                   count++;
               }
           }

           if(count == 1){
               ans = nums[i];
               break;
           }
       }
        return ans;
    }
};