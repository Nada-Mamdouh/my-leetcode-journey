class Solution {
public:
    int missingNumber(vector<int>& nums) {
        //O(n)
        int sm1 = 0, sm2 = 0, n = nums.size();
        for(int i = 0;i<nums.size();i++){
            sm1 += nums[i];
        }
        sm2 = n * (n+1)/2;
        return sm2 - sm1;
    }
};