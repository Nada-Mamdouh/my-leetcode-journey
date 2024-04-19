public class Solution {
    public bool IsPowerOfTwo(int n) {
        //Iterative approach
        if(n == 0) return false;
        if(n == 1) return true;
        while(n % 2 == 0){
            if(n == 2) return true;
            n /= 2;
        }
        return false;
    }
}