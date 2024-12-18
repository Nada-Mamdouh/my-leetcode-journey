class Solution {
public:
    int missingNumber(vector<int>& nums) {
        //BruteForce solution
        //TC: O(n2 + nlogn) //SC: O(1)
        int n = nums.size(), ans = 0;
        sort(nums.begin(), nums.end());
        for(int i= 1;i<=n;i++){
            int flag = 0;
            for(int j = 0;j <n;j++){
                if(nums[j] == i){
                    flag = 1;
                    break;
                 }
            }
            if(flag == 0){
                ans = i;
            }
            
        }
        return ans;
    }
};