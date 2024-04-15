public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        StringBuilder w1_sp = new StringBuilder();
        StringBuilder w2_sp = new StringBuilder();
        
        for(int i = 0;i<word1.Length;i++){
            w1_sp.Append(word1[i]);
        }
        for(int j = 0;j<word2.Length;j++){
            w2_sp.Append(word2[j]);
        }
        return w1_sp.Equals(w2_sp);
    }
}