class Solution {
public:
    int missingNumber(vector<int>& nums) {
        //Optimal approach
        //TC(O(n))   SC: O(1)
        //Using sum
        int n = nums.size();
        int sum1 = n * (n+1) / 2, s2 = 0;
        for(int i = 0;i<n;i++){
            s2 += nums[i];
        }
        return sum1 - s2;
    }
};