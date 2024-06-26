public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        //monotonic increasing stack:
        Dictionary<int,int> nextGreater = new Dictionary<int,int>();
        Stack<int> mono = new Stack<int>();
        int[] arr = new int[nums1.Length];
        
        mono.Push(nums2[0]);
        for(int i = 1;i<nums2.Length;i++){
            while(mono.Count > 0 && mono.Peek() < nums2[i]){
                int curr = mono.Pop();
                nextGreater.Add(curr, nums2[i]);
            }
            mono.Push(nums2[i]);
        }
        for(int i = 0;i<nums1.Length;i++){
            if(nextGreater.ContainsKey(nums1[i])){
                arr[i] = nextGreater[nums1[i]];
            }else{
                arr[i] = -1;
            }
            
        }
        return arr;
    }
}