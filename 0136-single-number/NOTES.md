**1- Brute force approach - nested loops**
```
//Brute force
//TC: O(n*n) sc: O(1)
int n = nums.size(),ans = 0, count = 0;
for(int i = 0;i<n;i++){
count = 0;
for(int j = 0;j<n;j++){
if(nums[i] == nums[j]){
count++;
}
}
​
if(count == 1){
ans = nums[i];
break;
}
}
return ans;
```
​
**2- Better solution ** using hashing / map
```
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
```
​
**3- Optimal solution - using xor**