public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int X = 0;
        for(int i = 0;i<operations.Length;i++){
            if(operations[i] == "++X" || operations[i] == "X++") X++;
            else{
                X--;
            }
        }
        return X;
    }
}