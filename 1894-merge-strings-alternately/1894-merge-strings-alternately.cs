public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder res = new(); int i = 0;
        int len = Math.Max(word1.Length,word2.Length);
        while(i<len){
            if(i < word1.Length)res.Append(word1[i]);
            if(i < word2.Length)res.Append(word2[i]);
            i++;
        }
        return res.ToString();
    }
}