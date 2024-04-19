public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 1) return true;
        if(n == 2 && n % 2 == 0) return true;
        else if(n == 0 || n % 2 == 1) return false;
        return IsPowerOfTwo(n/2);
        
    }
}