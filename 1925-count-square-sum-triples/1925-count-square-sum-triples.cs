public class Solution {
    public int CountTriples(int n) {
        int cnt = 0;
        for (int a = 3; a < n; a++){
            int sqrtA = a * a;
            for (int b = 3; b < n; b++){
                int sqrtSum = sqrtA + b * b;
                int c = (int)Math.Sqrt(sqrtSum);
                if (c > n)
                    break;
                if (c * c == sqrtSum)
                    cnt++;
            }
        }
        return cnt;
    }
}