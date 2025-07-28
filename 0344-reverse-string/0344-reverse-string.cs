public class Solution {
    public void ReverseString(char[] s) {
        Reverse(ref s, s.Length, 0);
    }
    void Reverse(ref char[] s,int n, int i){
        if(i >= n/2) return;
        char tmp = s[i];
        s[i] = s[n-i-1];
        s[n-i-1] = tmp;
        Reverse(ref s, n, i+1);
    }

}