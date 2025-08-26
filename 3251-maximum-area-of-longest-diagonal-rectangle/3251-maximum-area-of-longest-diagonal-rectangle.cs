public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        double maxDiagonal = 0; int maxArea = 0;
        for(int i = 0;i<dimensions.Length;i++){
            int length = dimensions[i][0];
            int width = dimensions[i][1];

            var currD = Math.Sqrt(length * length + width * width);
            var currArea = length * width;

            if(currD > maxDiagonal){
                maxDiagonal = currD;
                maxArea = currArea;
            }

            if(currD == maxDiagonal){
                maxArea = Math.Max(maxArea, currArea);
            }
            
        }
        return maxArea;
    }
}