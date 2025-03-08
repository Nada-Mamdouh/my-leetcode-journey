public class Solution {
    public int[] NextGreaterElements(int[] nums) {
       //Optimal approach using monotonic stack
       //Assume that we doubled the array
       int n = nums.Length;
       int[] ans = new int[n];
       Stack<int> mono = new();
       for(int i = 2 * n - 1;i>=0;i--){
          while(mono.Count != 0 && mono.Peek() <= nums[i % n]){
            mono.Pop();
          }
          if(i < n){
            ans[i] = mono.Count == 0? -1:mono.Peek();
          }
          mono.Push(nums[i % n]);
       }
       return ans;
    }
}