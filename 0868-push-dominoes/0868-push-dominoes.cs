public class Solution {
    public string PushDominoes(string dominoes) {
        int n = dominoes.Length;
        int[] right = new int[n], left = new int[n];
        char[] ans = new char[n];
        int r = 0, l = 0;
        for(int i = 0;i<n;i++){
            if(dominoes[i] == 'L') r = 0;
            else if(dominoes[i] == 'R')r = n;
            else if(r > 0) r--;
            right[i] = r;
        }
        for(int j = n-1;j>=0;j--){
            if(dominoes[j] == 'R') l = 0;
            else if(dominoes[j] == 'L') l = n;
            else if(l > 0) l--;
            left[j] = l;
        }
        for(int i = 0;i<n;i++){
            if(right[i] > left[i]) ans[i] = 'R';
            else if(left[i] > right[i]) ans[i] = 'L';
            else{
                ans[i] = '.';
            }
        }
        return new String(ans);
    }
}