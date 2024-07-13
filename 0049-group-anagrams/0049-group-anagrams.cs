public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> ans = new List<IList<string>>();
        Dictionary<string, List<string>> dict = new Dictionary<string,List<string>>();
        
        for(int i = 0;i<strs.Length;i++){
            string sorted = SortString(strs[i]);
            if(dict.ContainsKey(sorted)){
                dict[sorted].Add(strs[i]);
            }else{
                dict.Add(sorted,new List<string>(){strs[i]});
            }
        }
        foreach(var item in dict){
            List<string> tmp = new List<string>();
            foreach(var ele in item.Value){
                tmp.Add(ele);
            }
            ans.Add(tmp);
            
        }
        return ans;
    }
    public static string SortString(string s){
        char[] cArr = s.ToCharArray();
        Array.Sort(cArr);
        return new String(cArr);
    }
}