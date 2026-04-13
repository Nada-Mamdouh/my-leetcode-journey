class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        unordered_set<int> stt;
        for(int i = 0;i<nums.size();i++){
            if(stt.find(nums[i]) != stt.end()){
                return true;
            }
            stt.insert(nums[i]);
        }
        return false;
    }
};