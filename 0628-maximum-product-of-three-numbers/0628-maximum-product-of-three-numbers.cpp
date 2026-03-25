class Solution {
public:
    int maximumProduct(vector<int>& nums) {
        int n = nums.size();
        sort(nums.begin(),nums.end(), greater<int>());
        int maxProd = nums[0];
        int tmp1 = maxProd * nums[1] * nums[2];
        int tmp2 = maxProd * nums[n-1] * nums[n-2];
        maxProd = max(tmp1, tmp2);
        return maxProd;
    }
};