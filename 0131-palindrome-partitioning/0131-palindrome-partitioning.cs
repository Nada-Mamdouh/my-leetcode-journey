public class Solution {
    IList<IList<string>> ans = new List<IList<string>>();
    public IList<IList<string>> Partition(string s) {
        func(s, 0, new List<string>());
        return ans;
    }
    void func(string str, int idx, List<string> path){
        if(idx == str.Length){
            ans.Add(new List<string>(path));
            return;
        }
        for(int i = idx;i<str.Length;i++){
            if(IsPalindrome(str, idx, i)){
                path.Add(str.Substring(idx,i - idx + 1));
                func(str, i + 1, path);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
    bool IsPalindrome(string str, int start, int end){
        //if(start < str.Length && end < str.Length){
            while(start < end){
                if(str[start] != str[end]) return false;
                start++;
                end--;
            }
        //}
        
        return true;
    }
}