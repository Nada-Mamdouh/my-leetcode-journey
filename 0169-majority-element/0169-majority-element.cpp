class Solution {
public:
    int majorityElement(vector<int>& nums) {
        int n = nums.size();
        map<int, int> mpp;
        for(int i = 0;i<n;i++){
            mpp[nums[i]]++;
        }
        for(auto ele:mpp){
            if(ele.second > (n/2)) return ele.first;
        }
        return -1;
    } 
};