class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        // Optimal solution 
        // Applying kadane's algorithm 
        // TC: O(n), SC: O(1)
        int n = nums.size();
        int sum = 0;
        int maxi = nums[0];
        for(int i = 0;i<n;i++){
            sum += nums[i];
            if(sum > maxi) maxi = sum;
            if(sum < 0) sum = 0;
        }
        return maxi;
    }
};