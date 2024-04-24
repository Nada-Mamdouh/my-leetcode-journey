public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int empsWhoMetTheTarget = 0;
        for(int i = 0;i<hours.Length;i++){
            if(hours[i] >= target) empsWhoMetTheTarget++;
        }
        return empsWhoMetTheTarget;
    }
}