public class Solution {
    public int LongestPalindrome(string s) {
        //SC: O(len(s)) - TC: 3(len(s))
        Dictionary<char, int> dict = new();
        int len = 0;
        for(int i = 0;i<s.Length;i++){
            if(!dict.ContainsKey(s[i])) dict.Add(s[i],0);
            dict[s[i]]++;
        }
        foreach(var kvp in dict){
            if(kvp.Value % 2 == 0){
                len += kvp.Value;
            }else{
                len += (kvp.Value - 1);
            }
        }
        foreach(var kvp in dict){
            if(kvp.Value == 1 || (kvp.Value % 2 != 0)){
                len += 1;
                break;
            }
            // else if(kvp.Value == s.Length){
            //     len = kvp.Value;
            //     break;
            // }
        }
        return len;
    }
}