}
```
​
**2- Better solution **
using hashing
```
int missingNumber(vector<int>& nums) {
//Better solution
//TC: O(nlogn + 2n), SC: O(n)
int n = nums.size(), ans = 0;
vector<int> hash(n+1,0);
sort(nums.begin(),nums.end());
for(int i = 0;i<n;i++){
hash[nums[i]] = 1;
}
for(int i = 1;i<=n;i++){
if(hash[i] != 1){
ans = i;
break;
}
}
return ans;
```
​
**3- Optimal approach **
using either sum of natural numbers or xor
=> Xor is better because it's more optimized for larger numbers
​