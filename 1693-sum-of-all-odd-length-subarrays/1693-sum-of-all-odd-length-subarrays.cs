public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int total = 0;
        for(int i = 0;i<arr.Length;i++){
            for(int j = i;j<arr.Length;j++){
                int len = (j - i + 1);
                int summ = 0;
                if((len & 1) == 1){
                    for(int k = i; k<=j;k++){
                        summ += arr[k];
                    }
                    total += summ;
                }
            }
        }

        return total;
    }
}
