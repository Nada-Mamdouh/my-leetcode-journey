public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] res = new int[len];
        if(len == 1) return res;
        for(int i = 0;i<len;i++){
            for(int j = i+1; j<len;j++){
                if(temperatures[j] > temperatures[i]){
                    res[i] = j - i;
                    break;
                }
            }
        }
        return res;
        
    }
}