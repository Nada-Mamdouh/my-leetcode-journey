public class Solution {
    public int MaximumPopulation(int[][] logs) {
        int[] population = new int[101]; // For years 1950 to 2050

        foreach (var log in logs) {
            int birth = log[0];
            int death = log[1];
            population[birth - 1950]++;
            population[death - 1950]--;
        }

        int maxPop = 0, year = 1950, currentPop = 0;
        for (int i = 0; i < 101; i++) {
            currentPop += population[i];
            if (currentPop > maxPop) {
                maxPop = currentPop;
                year = 1950 + i;
            }
        }

        return year;
    }
}
