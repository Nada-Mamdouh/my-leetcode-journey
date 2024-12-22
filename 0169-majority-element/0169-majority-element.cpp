class Solution {
public:
    int majorityElement(vector<int>& nums) {
        int n = nums.size();
        int ele, cnt = 0;
        for(int i = 0;i<n;i++){
            if(cnt == 0){
                ele = nums[i];
                cnt = 1;
            }else if(nums[i] == ele) cnt++;
            else cnt--;
        }
        int cnt2 = 0;
        for(int i = 0;i<n;i++){
            if(ele == nums[i])cnt2++;
            if(cnt2 > (n/2)) return nums[i];
        }
        return -1;
    } 
};