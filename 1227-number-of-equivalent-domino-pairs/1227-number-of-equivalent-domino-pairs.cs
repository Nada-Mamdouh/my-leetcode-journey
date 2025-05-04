public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        int n = dominoes.Length, ans = 0, cnt = 0;
        Dictionary<(int,int), int> dict = new();
        for(int i = 0;i<n;i++){
            Array.Sort(dominoes[i]);
            var t1 = (dominoes[i][0],dominoes[i][1]);
            if(!dict.ContainsKey(t1)) dict.Add(t1,0);
            dict[t1]++;
        };
        foreach(var kvp in dict){
            if(kvp.Value > 1) ans += (kvp.Value * (kvp.Value-1) / 2);
        }
        return ans;
    }
}