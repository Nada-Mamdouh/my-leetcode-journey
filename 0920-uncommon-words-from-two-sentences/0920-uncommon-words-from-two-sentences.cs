public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        //TC: O(m + n) + O(m + n) + O(m + n) for converting list to array
        //SC: O(m + n) + O(m + n) for returning list
        Dictionary<string,int> dict = new();
        List<string> ans = new List<string>();
        var s1Arr = s1.Split(" ");
        var s2Arr = s2.Split(" ");
        for(int i = 0;i<s1Arr.Length;i++){
            if(!dict.ContainsKey(s1Arr[i])){
                dict.Add(s1Arr[i],1);
            }else{
                dict[s1Arr[i]]++;
            }
        }
        for(int i = 0;i<s2Arr.Length;i++){
            if(!dict.ContainsKey(s2Arr[i])){
                dict.Add(s2Arr[i],1);
            }else{
                dict[s2Arr[i]]++;
            }
        }
        foreach(var kvp in dict){
            if(kvp.Value == 1){
                ans.Add(kvp.Key);
            }
        }
        return ans.ToArray();
    }
}