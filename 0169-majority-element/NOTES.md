**1- Brute Fore**
//TC: O(n2) SC: O(1);
```
int majorityElement(vector<int>& nums) {
int n = nums.size();
for(int i = 0;i<n;i++){
int cnt = 0;
for(int j = 0;j<n;j++){
if(nums[i] == nums[j]) cnt++;
}
if(cnt > (n/2)) return nums[i];
}
return -1;
}
```
**2- Better using hashing**
//TC: O(nlogn + n) SC: O(n)
```
int majorityElement(vector<int>& nums) {
int n = nums.size();
map<int, int> mpp;
for(int i = 0;i<n;i++){
mpp[nums[i]]++;
}
for(auto ele:mpp){
if(ele.second > (n/2)) return ele.first;
}
return -1;
}
```
**3- Optimal - using Moore's voting algorithm**