public class Solution {
    public int SimilarPairs(string[] words) {
        int ans = 0;
        for(int i = 0;i<words.Length;i++){
            for(int j = i + 1;j<words.Length;j++){
                if(areTheSame(words[i], words[j])) ans++;
            }
        }
        return ans;
    }
    private bool areTheSame(string w1, string w2){
        HashSet<char> c1 = new HashSet<char>(w1.ToCharArray());
        HashSet<char> c2 = new HashSet<char>(w2.ToCharArray());
        foreach(var c in w2){
            if(!c1.Contains(c)) return false;
        }
        foreach(var c in w1){
            if(!c2.Contains(c)) return false;
        }
        return true;
    }
}