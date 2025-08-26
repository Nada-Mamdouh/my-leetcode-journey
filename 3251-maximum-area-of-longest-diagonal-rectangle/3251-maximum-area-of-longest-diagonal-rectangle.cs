public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        Dictionary<double,List<double>> dict = new();
        double maxDiagonal = 0;

        for(int i = 0;i<dimensions.Length;i++){
            double length =(double) dimensions[i][0];
            double width = (double) dimensions[i][1];
            double diagonal = Math.Sqrt( (length * length) + (width * width));

            if(diagonal > maxDiagonal){
                maxDiagonal = diagonal;
            }

            if(!dict.ContainsKey(diagonal)){
                dict.Add(diagonal, new List<double>());
            }
            dict[diagonal].Add((double)(length * width));
            
        }

        if(dict[maxDiagonal].Count == 1) return (int) dict[maxDiagonal][0];
        int maxArea = 0; 
        foreach(var area in dict[maxDiagonal]){
            maxArea = Math.Max(maxArea, (int) area);
        }
        return maxArea;
    }
}