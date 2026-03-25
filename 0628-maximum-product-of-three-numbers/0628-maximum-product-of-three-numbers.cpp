class Solution {
public:
    int maximumProduct(vector<int>& nums) {
        int maxProd = 1, n = nums.size();
        sort(nums.begin(),nums.end(), greater<int>());
        int tmp1 = nums[0] * nums[1] * nums[2];
        int tmp2 = nums[n-1] * nums[n-2] * nums[0];
        maxProd = max(tmp1, tmp2);
        return maxProd;
    }
};