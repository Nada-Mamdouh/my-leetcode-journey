public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> dict = new Dictionary<char,int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        for(int i = 0;i<s.Length;i++){
            if(!dict.ContainsKey(s[i])){
                dict.Add(s[i],1);
            }else{
                dict[s[i]]++;
            }
        }
        for(int j = 0;j<t.Length;j++){
            if(!dict2.ContainsKey(t[j])){
                dict2.Add(t[j],1);
            }else{
                dict2[t[j]]++;
            }
        }
        
        for(int k = 0;k<s.Length;k++){
            if(!dict2.ContainsKey(s[k]) || 
               (dict2.ContainsKey(s[k]) && dict[s[k]] != dict2[s[k]])){
                return false;
            }
        }
        return true;
    }
}