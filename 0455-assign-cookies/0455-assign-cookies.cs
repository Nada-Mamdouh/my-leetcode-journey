public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        int n = g.Length, m = s.Length, l = 0, r = 0;
        Array.Sort(g);
        Array.Sort(s);
        while(l < n && r < m){
            if(s[r] >= g[l]) l++;
            r++;
        }
        return l;
    }
}