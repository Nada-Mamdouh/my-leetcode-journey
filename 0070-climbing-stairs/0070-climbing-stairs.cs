public class Solution {
    Dictionary<int,int> memo = new Dictionary<int,int>();
    public int ClimbStairs(int n) {
        int res = 0;
        if(memo.ContainsKey(n)) return memo[n];
        if(n <= 2){
            res = n;
        }else{
            res = ClimbStairs(n - 1) + ClimbStairs(n-2);
        }
        memo.Add(n, res);
        return res;

    }
}