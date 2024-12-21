**1- Using any sorting algo**
here I used selection sort with O(n2) but we can use *merge sort* as well
=>Mergesort : TC: O(nlogn)    SC: O(n) for temp arrays we use
```
//selection sort
//TC: O(n2)
//1-get the smallest(select)
int n = nums.size();
for(int i = 0;i<=n-2;i++){
int mini = i;
for(int j = i;j<=n-1;j++){
mini = nums[j] < nums[mini]?j:mini;
}
//2-swap
int tmp = nums[mini];
nums[mini] = nums[i];
nums[i] = tmp;
​
}
```
​
**2- Better **
*using 3 counter variables*
TC: O(2n)
SC: O(1)**
**3- Optimal**
using *Dutch National flag algo*
which states: we have 3 pointers low, mid and high
* from 0 -> low-1 all elements are zeroes
* from low -> mid - 1 all elements are ones
* from mid -> high - 1 all elements are not sorted
* from high -> n-1 all elements are twos
=> TC: O(n)          SC: O(1)