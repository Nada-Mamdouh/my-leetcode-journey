# first solution for Manara on 12th July, 2024:
Using HashMap or HashSet, I believe HashSet is better anyway since each number is unique, I might go with that solution,
​
# Second solution the follow up to be solved another time isA
​
======================18/12/2024
**1- Brute force solution**
```
int missingNumber(vector<int>& nums) {
//BruteForce solution
//TC: O(n2 + nlogn) //SC: O(1)
int n = nums.size(), ans = 0;
sort(nums.begin(), nums.end());
for(int i= 1;i<=n;i++){
int flag = 0;
for(int j = 0;j <n;j++){
if(nums[j] == i){
flag = 1;
break;
}
}
if(flag == 0){
ans = i;
}
}
return ans;
}
```