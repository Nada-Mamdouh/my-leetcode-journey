public class Solution {
    public int ScoreOfString(string s) {
        int i = 0, j = 1, score = 0;
        while(i < s.Length && j<s.Length){
            int tmp = Math.Abs(s[i] - s[j]);
            score += tmp;
            i++;
            j++;
        }
        return score;
    }
}