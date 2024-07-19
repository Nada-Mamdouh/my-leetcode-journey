public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> nums1Set = new HashSet<int>();
        HashSet<int> nums2Set = new HashSet<int>();
        
        List<int> res = new List<int>();
        for(int i = 0;i<nums1.Length;i++){
            if(!nums1Set.Contains(nums1[i])){
                nums1Set.Add(nums1[i]);
            }
        }
        for(int i = 0;i<nums2.Length;i++){
            if(!nums2Set.Contains(nums2[i])){
                nums2Set.Add(nums2[i]);
            }
        }
        foreach(var item in nums2Set){
            if(nums1Set.Contains(item)){
                res.Add(item);
            }
        }
        return res.ToArray();
        
    }
}