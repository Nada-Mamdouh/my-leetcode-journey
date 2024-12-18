class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        //TC: O(n) , SC: O(1)
        int maxim = 0, counter = 0;
        int n = nums.size();
        for(int i = 0;i<n;i++){
            if(nums[i] == 1){
                counter++;
                maxim = max(maxim, counter);
            }else{
                counter = 0;
            }
        }
        return maxim;
    }
};