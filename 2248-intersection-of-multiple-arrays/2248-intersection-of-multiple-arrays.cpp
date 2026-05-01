class Solution {
public:
    vector<int> intersection(vector<vector<int>>& nums) {
        unordered_map<int,int> present;
        vector<int> ans;
        for(int i = 0;i<nums.size();i++){
            for(int j = 0;j<nums[i].size();j++){
                if(present.find(nums[i][j]) != present.end()){
                    present[nums[i][j]]++;
                }else{
                   present[nums[i][j]] = 1; 
                }
            }
        }
        int num = nums.size();
        for(auto item : present){
            if(item.second == num){
                ans.push_back(item.first);
            }
        }
        sort(ans.begin(), ans.end());
        return ans;
    }
};