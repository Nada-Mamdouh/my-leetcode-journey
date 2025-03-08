public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int len1 = nums1.Length, len2 = nums2.Length;
        int[] ans = new int[len1];
        Stack<int> mono = new Stack<int>();
        Dictionary<int, int> dict = new();
        for(int i = len2 -1;i>=0;i--){
            while(mono.Count != 0 && mono.Peek() <= nums2[i]){
                mono.Pop();
            }
            if(mono.Count == 0) dict[nums2[i]] = -1;
            else{
                dict[nums2[i]] = mono.Peek();
            }
            mono.Push(nums2[i]);
        };
        for(int i = 0;i<len1;i++){
            ans[i] = dict[nums1[i]];
        }
        return ans;

    }
}