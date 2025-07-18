public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0) return result;

        int top = 0;
        int bottom = matrix.Length;
        int left = 0;
        int right = matrix[0].Length;

        while (left < right && top < bottom)
        {
            // Traverse top row → (left to right)
            for (int i = left; i < right; i++)
                result.Add(matrix[top][i]);
            top++;

            // Traverse right column ↓ (top to bottom)
            for (int i = top; i < bottom; i++)
                result.Add(matrix[i][right - 1]);
            right--;

            // Check if rows/columns still exist
            if (!(left < right && top < bottom))
                break;

            // Traverse bottom row ← (right to left)
            for (int i = right - 1; i >= left; i--)
                result.Add(matrix[bottom - 1][i]);
            bottom--;

            // Traverse left column ↑ (bottom to top)
            for (int i = bottom - 1; i >= top; i--)
                result.Add(matrix[i][left]);
            left++;
        }

        return result;
    }
}
