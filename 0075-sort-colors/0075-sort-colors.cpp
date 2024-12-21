class Solution {
public:
    void sortColors(vector<int>& nums) {
        //Better solution
        //TC: O(2n)
        int n = nums.size();
        int countZ = 0, countO = 0, countT = 0;
        for(int i = 0;i<n;i++){
            if(nums[i] == 0) countZ++;
            else if(nums[i] == 1) countO++;
            else{
                countT++;
            }
        }
        for(int i = 0;i<countZ;i++){
            nums[i] = 0;
        }
        for(int i = countZ; i<countZ+countO;i++){
            nums[i] = 1;
        }
        for(int i = countZ + countO ; i<n;i++){
            nums[i] = 2;
        }
    
    }
};