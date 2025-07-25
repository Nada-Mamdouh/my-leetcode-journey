public class Solution {
    public int NumberOfSteps(int num) {
        int steps = 0;
        while(num > 0){
            if((num & 1) == 1) num -= 1;
            else num /= 2;
            steps++;
        }
        return steps;
    }
}