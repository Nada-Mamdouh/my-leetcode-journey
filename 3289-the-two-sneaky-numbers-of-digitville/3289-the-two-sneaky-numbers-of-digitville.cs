public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Dictionary<int, int> dict = new();
        List<int> result = new();
        for(int i = 0;i<nums.Length;i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],0);
            }
            dict[nums[i]]++;
        }
        foreach(var ele in dict){
            if(ele.Value == 2){
                result.Add(ele.Key);
            }
        }
        return result.ToArray();
    }
}