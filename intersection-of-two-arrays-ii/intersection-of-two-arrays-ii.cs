public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> dict1 = new Dictionary<int,int>();
        Dictionary<int, int> dict2 = new Dictionary<int,int>();
        List<int> res = new List<int>();
        for(int i = 0;i<nums1.Length;i++){
            if(!dict1.ContainsKey(nums1[i])){
                dict1.Add(nums1[i],1);
            }else{
                dict1[nums1[i]]++;
            }
        }
        for(int j = 0;j<nums2.Length;j++){
            if(!dict2.ContainsKey(nums2[j])){
                dict2.Add(nums2[j],1);
            }else{
                dict2[nums2[j]]++;
            }
        }
        foreach(var kvp in dict1){
            if(dict2.ContainsKey(kvp.Key)){
                int count = Math.Min(dict2[kvp.Key] , dict1[kvp.Key]);
                while(count-- > 0){
                    res.Add(kvp.Key);
                }
            }
        }
        return res.ToArray();
    }
}