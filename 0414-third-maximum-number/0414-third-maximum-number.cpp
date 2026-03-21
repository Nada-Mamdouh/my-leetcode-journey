class Solution {
public:
    int thirdMax(vector<int>& nums) {
        long firstMax = LONG_MIN, secondMax = LONG_MIN, thirdMax = LONG_MIN;
        sort(nums.begin(), nums.end());
        for(int i = 0;i<nums.size();i++){
            if(nums[i] > firstMax){
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = nums[i];
            }
        }
        if(thirdMax == LONG_MIN) return firstMax;
        return thirdMax;
    }
};