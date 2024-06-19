public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] res = new int[len];
        Stack<int> monotonus = new Stack<int>();
        for(int i = 0;i<len;i++){
            while(monotonus.Count >0 && 
                  temperatures[i] > temperatures[monotonus.Peek()]){
                int idx = monotonus.Pop();
                res[idx] = i - idx;
            }
            monotonus.Push(i);
        }
        return res;
        
    }
}