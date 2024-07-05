public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        List<int> numsListQ = new List<int>(nums);
        int res = 0;
        //Build max heap from the list:
        BuildMaxHeap(ref numsListQ);
        
        for(int i = 0;i<k;i++){
            res = Dequeue(ref numsListQ);
        }
        return res;
    }
    public static void BuildMaxHeap(ref List<int> nums){
        for(int i = nums.Count/2-1; i>=0;i--){
            HeapifyDown(i, ref nums);
        }
    }
    public static void Enqueue(ref List<int> nums, int num){
        nums.Add(num);
        int idx = nums.Count - 1;
        HeapifyUp(idx, ref nums);
    }
    public static int Dequeue(ref List<int> nums){
        int root = nums[0];
        nums[0] = nums[nums.Count - 1];
        nums.RemoveAt(nums.Count - 1);
        HeapifyDown(0, ref nums);
        return root;
    }
    public static void HeapifyUp(int index, ref List<int> nums){
        int parent = (index - 1)/2;
        while(index > 0 && nums[index] > nums[parent]){
            Swap(parent, index,ref nums);
            index = parent;
            parent = (index - 1)/2;
        }
    }
    public static void HeapifyDown(int index, ref List<int> nums){
        int lastIdx = nums.Count - 1;
        while(true){
            int left = index * 2 + 1;
            if(left > lastIdx) break;
            int right = left + 1;
            int maxChild = left;
            if(right <= lastIdx && nums[right] > nums[left]){
                maxChild = right;
            }
            if(nums[index] > nums[maxChild]) break;
            Swap(index, maxChild, ref nums);
            index = maxChild;
        }
    }
    public static void Swap(int idx1, int idx2, ref List<int> nums){
        int tmp = nums[idx1];
        nums[idx1] = nums[idx2];
        nums[idx2] = tmp;
    }
}