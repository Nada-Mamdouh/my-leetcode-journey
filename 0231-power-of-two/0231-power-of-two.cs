public class Solution {
    public bool IsPowerOfTwo(int n) {
        return isPow((double)n);
    }
    bool isPow(double n){
        if(n <= 0) return false;
        if(n == 1) return true;
        if(n % 2 != 0) return false;
        return isPow(n/2);
    }
}