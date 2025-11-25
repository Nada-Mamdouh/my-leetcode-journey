public class Solution {
    public int SmallestRepunitDivByK(int k) {

        if(k % 2 == 0 || k % 5 == 0) return -1;
        int remainder = 0, len = 0;
        for(int i = 0;i<k;i++){
            remainder = (remainder * 10 + 1) % k;
            len++;
            if(remainder == 0) return len;
        }
        return -1;
    }
}