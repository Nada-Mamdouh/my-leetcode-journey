public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int[]> dict = new Dictionary<char,int[]>();
        
        for(int i = 0;i<s.Length;i++){
            int[] arr = new int[2];
            if(!dict.ContainsKey(s[i])){
                arr[0] = 1;
                arr[1] = i;
                dict.Add(s[i],arr);
            }else{
                dict[s[i]][0]++;
            }
        }
        foreach(var kvp in dict){
            if(kvp.Value[0] == 1){
                return kvp.Value[1];
            }
        }
        return -1;
        
    }
}