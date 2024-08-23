public class Solution {
    Dictionary<int, int> stepsCache = new Dictionary<int, int>();
    public int ClimbStairs(int n) {
        if(stepsCache.ContainsKey(n)) return stepsCache[n];
        int res;
        if(n <= 2){
            res = n;
        }else{
            res = ClimbStairs(n-1) + ClimbStairs(n-2);
        }
        stepsCache.Add(n, res);
        return res;
    }
}