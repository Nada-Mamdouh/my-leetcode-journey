class Solution {
public:
    int singleNumber(vector<int>& nums) {
        //Optimal solution
        //TC: O(n) - SC: O(1)
        int xor1 = 0, n = nums.size();
        for(int i = 0;i<n;i++){
            xor1 ^= nums[i];
        }
        return xor1;
        
    }
};