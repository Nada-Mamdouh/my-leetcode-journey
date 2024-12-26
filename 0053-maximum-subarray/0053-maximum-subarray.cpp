class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        //Optimal Solution
        //TC: O(n) - SC: O(1)
        int n = nums.size();
        int maxi = INT_MIN, sm = 0;
        for(int i = 0;i<n;i++){
            sm += nums[i];
            maxi = max(maxi, sm);
            if(sm < 0) sm = 0;
        }
        return maxi;
    }
};