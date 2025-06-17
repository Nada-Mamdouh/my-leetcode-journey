public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int n = score.Length, rank = 1;
        Dictionary<int, int> dict = new();
        string[] ans = new string[n];
        for(int i = 0; i<n; i++) dict.Add(score[i],i);
        Array.Sort(score);
        for(int j = n-1;j>=0;j--){
            if(j == n-1) ans[dict[score[j]]] = "Gold Medal";
            else if(j == n-2) ans[dict[score[j]]] = "Silver Medal";
            else if(j == n-3) ans[dict[score[j]]] = "Bronze Medal";
            else ans[dict[score[j]]] = rank.ToString();
            rank++;
        }
        return ans;
    }
}