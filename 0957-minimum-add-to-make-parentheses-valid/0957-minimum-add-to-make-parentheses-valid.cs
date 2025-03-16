public class Solution {
    public int MinAddToMakeValid(string s) {
        //TC: O(n) - O(n) -> O(2n)
        //SC: O(n)
        Stack<char> st = new Stack<char>();
        int ans = 0;
        for(int i = 0;i<s.Length;i++){
            if(st.Count > 0 && s[i] == ')' && st.Peek() == '('){
                st.Pop();
            }else{
                st.Push(s[i]);
            }
        }
        while(st.Count > 0){
            ans++;
            st.Pop();
        }
        return ans;
    }
}