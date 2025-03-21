public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        //This can be solved in 2 ways:
        //1- sliding window    2- prefix sum
        //Let's go with sliding window:

        //TC: O(2k)
        //SC: O(1)

        int leftSum = 0, rightSum = 0, maxPoints = 0;
        for(int j = 0;j<k;j++){
            leftSum += cardPoints[j];
        }
        Console.WriteLine(leftSum);
        maxPoints = leftSum;
        int rightIdx = cardPoints.Length - 1;
        for(int g = k-1; g >= 0;g--){
            leftSum -= cardPoints[g];
            rightSum += cardPoints[rightIdx];
            maxPoints = Math.Max(maxPoints, leftSum + rightSum);
            rightIdx--;
        }
        return maxPoints;
    }
}