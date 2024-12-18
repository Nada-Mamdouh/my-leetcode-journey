class Solution {
public:
    int singleNumber(vector<int>& nums) {
        //Better solution
        //where m is the size of the map which is equal to n/2 + 1;
        //TC: O(nlogm) + O(n/2 + 1)  - SC: O(n/2 + 1)
        int n = nums.size(), ans = 0;
        map<int, int> mpp;
        for(int i = 0;i<n;i++){
            mpp[nums[i]]++;
        }
        for(auto it:mpp){
            if(it.second == 1){
                ans = it.first;
                break;
            }
        }
        return ans;
        
    }
};