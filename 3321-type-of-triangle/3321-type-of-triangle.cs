public class Solution {
    public string TriangleType(int[] nums) {
        int firstSide = nums[0],  secondSide = nums[1] , thirdSide = nums[2];
        if(CantFormATriangle(firstSide, secondSide, thirdSide)) return "none";
        else if(IsScalene(firstSide, secondSide, thirdSide)) return "scalene";
        else if(IsEquilateral(firstSide, secondSide, thirdSide)) return "equilateral";
        else return "isosceles";
    }
    bool CantFormATriangle(int f, int s, int t){
        if((f >= (s+t)) || s >= (f+t) || t >= (f+s) ) return true;
        return false;
    }
    Func<int,int,int,bool> IsScalene = (f,s,t) => ((f != s) && (s != t) && (f != t));
    Func<int,int,int,bool> IsEquilateral = (f,s,t) => ((f == s) && (s == t) && (f == t));
}