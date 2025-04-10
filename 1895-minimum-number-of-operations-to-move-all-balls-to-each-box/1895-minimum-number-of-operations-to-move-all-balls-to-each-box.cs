public class Solution {
    public int[] MinOperations(string boxes) {
        //Brute force:
        //TC: O(n^2) - SC: O(n) for returning answer
        int[] ans = new int[boxes.Length];
        int summ = 0;
        for(int i = 0;i<boxes.Length;i++){
            summ = 0;
            for(int j = 0;j<boxes.Length;j++){
                if(j != i && boxes[j] == '1'){
                    summ += Math.Abs(i - j);
                }
            }
            ans[i] = summ;
        }
        return ans;
    }
}