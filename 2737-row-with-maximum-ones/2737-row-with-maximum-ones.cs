public class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        int minIndex = m-1, onesCount = 0;
        for(int i = 0;i<m;i++){
            int tmp = 0;
            for(int j = 0;j<n;j++){
                tmp += mat[i][j];
            }
            if(tmp > onesCount){
                onesCount = tmp;
                minIndex = i;
            }
            if(tmp == onesCount){
                minIndex = Math.Min(minIndex, i);
            }
        }
        return new int[]{minIndex, onesCount};
    }
}