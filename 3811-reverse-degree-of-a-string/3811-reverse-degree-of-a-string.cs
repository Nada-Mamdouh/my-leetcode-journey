public class Solution {
    public int ReverseDegree(string s) {
        int result = 0;
        for(int i = 0;i<s.Length;i++){
            int idx = 'z' - s[i] + 1;
            result += (idx) * (i+1);
        }
        return result;
    }
}