class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<long,int> mpp;
        vector<int> v(2);
        for(int i = 0;i<nums.size();i++){
            long val = target - nums[i];
            if(mpp.find(val) != mpp.end()){
                v[0] = mpp[val];
                v[1] = i;
                break;
            }
            mpp.insert({nums[i],i});
        }
        return v;
    }
};