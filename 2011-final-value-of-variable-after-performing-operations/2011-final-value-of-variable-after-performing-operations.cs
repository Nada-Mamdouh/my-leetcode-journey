public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int X = 0;
        for(int i = 0;i<operations.Length;i++){
            X += 44 - operations[i][1];
        }
        return X;
    }
}