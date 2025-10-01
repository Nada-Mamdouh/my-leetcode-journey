public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int bottleDrinked = 0;
        int eb = 0;
        while(numBottles > 0){
            bottleDrinked += numBottles;
            eb += numBottles;

            numBottles = eb / numExchange;
            eb = eb % numExchange;
        }
        return bottleDrinked;
    }
}