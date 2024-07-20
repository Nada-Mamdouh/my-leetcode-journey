public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> mappingDict1 = new Dictionary<char,char>();
        Dictionary<char,char> mappingDict2 = new Dictionary<char,char>();
        for(int i = 0;i<s.Length;i++){
            if(mappingDict1.ContainsKey(s[i])){
                if(mappingDict1[s[i]] != t[i]){
                    return false;
                }
            }else{
                if(mappingDict2.ContainsKey(t[i]) && mappingDict2[t[i]] != s[i]){
                    return false;
                }
                mappingDict1.Add(s[i],t[i]);
                mappingDict2.Add(t[i],s[i]);
            }
        }
        return true;
    }
}