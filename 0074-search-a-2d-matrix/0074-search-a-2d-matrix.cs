public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix == null || matrix.Length == 0) return false;
        int rows = matrix.Length, cols = matrix[0].Length;
        int low = 0, high = rows * cols - 1;
        while(low <= high){
            int mid = low + (high - low) / 2;
            var coordinates = getCoordinates(mid,cols);
            if(matrix[coordinates[0]][coordinates[1]] == target) return true;
            else if(matrix[coordinates[0]][coordinates[1]] > target)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return false;
    }
    int[] getCoordinates(int i, int cols){
        int row = i / cols;
        int col = i % cols;
        return new int[]{row, col};
    }
}