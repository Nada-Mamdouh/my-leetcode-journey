class Solution {
public:
    vector<int> sortArrayByParity(vector<int>& nums) {
        int j = 0, n = nums.size();
        for(int i = n-1;i >= 0;i--){
            while(j < i && (nums[j] % 2) == 0){
                j++;
            }
            if((nums[i] % 2) == 0){
                if(j <= i && (nums[j] % 2) == 1){
                    int tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
                j++;
            }
        }
        return nums;
    }
    
};