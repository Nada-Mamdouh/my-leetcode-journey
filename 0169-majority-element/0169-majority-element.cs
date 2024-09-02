public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int,int>();
        int result = 0;
        foreach(var ele in nums){
            if(dict.ContainsKey(ele)) dict[ele]++;
            else{
                dict.Add(ele, 1);
            }
        }
        foreach(var kvp in dict){
            if(kvp.Value > nums.Length/2){
                result = kvp.Key;
            }
        }
        return result;
    }
}