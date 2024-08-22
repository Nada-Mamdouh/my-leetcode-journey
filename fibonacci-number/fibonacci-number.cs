public class Solution {
    Dictionary<int, int> cache = new Dictionary<int, int>();
    public int Fib(int n) {
        if(cache.ContainsKey(n)) return cache[n];
        int result;
        if(n<2){
            result = n;
        }else{
            result = Fib(n-1) + Fib(n-2);
        }
        cache.Add(n, result);
        return result;
    }
}