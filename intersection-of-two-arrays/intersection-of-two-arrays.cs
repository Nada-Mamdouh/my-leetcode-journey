public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> nums1Set = new HashSet<int>();        
        HashSet<int> res = new HashSet<int>();
        
        for(int i = 0;i<nums1.Length;i++){
            if(!nums1Set.Contains(nums1[i])){
                nums1Set.Add(nums1[i]);
            }
        }
        for(int i = 0;i<nums2.Length;i++){
            if(nums1Set.Contains(nums2[i]) && !res.Contains(nums2[i])){
                res.Add(nums2[i]);
            }
        }

        return res.ToArray();
        
    }
}