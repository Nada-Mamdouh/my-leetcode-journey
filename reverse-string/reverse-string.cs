public class Solution {
    public void ReverseString(char[] s) {
        recurrReverse(0, s.Length-1 ,ref s);
    }
    public void recurrReverse(int start, int end, ref char[] chars){
        if(start >= end){
            return;
        }
        char tmp = chars[start];
        chars[start] = chars[end];
        chars[end] = tmp;
        recurrReverse(start + 1, end -1,ref chars);
    }
}