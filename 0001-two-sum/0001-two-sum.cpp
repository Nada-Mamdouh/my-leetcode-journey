class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        //Better 
        //Time Complexity: O(nlogn)
        //SC: O(n)
        int n = nums.size();
        map<int, int>mpp;
        vector<int> ans(2,0);
        for(int i = 0;i<n;i++){
            int more = target - nums[i];
            if(mpp.find(more) != mpp.end()){
                ans[0] = mpp[more];
                ans[1] = i;
                break;
            }
            mpp[nums[i]] = i;
        }
        return ans;
    }
};