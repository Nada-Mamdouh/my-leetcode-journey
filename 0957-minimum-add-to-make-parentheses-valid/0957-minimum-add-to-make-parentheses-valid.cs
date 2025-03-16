public class Solution {
    public int MinAddToMakeValid(string s) {
        Stack<char> st = new Stack<char>();
        int ans = 0;
        for(int i = 0;i<s.Length;i++){
            if(st.Count == 0 || (st.Count > 0 && s[i] == ')' && st.Peek() != '(') || s[i] == '('){
                st.Push(s[i]);
            }
            if(st.Count > 0 && s[i] == ')' && st.Peek() == '('){
                st.Pop();
            }
        }
        while(st.Count > 0){
            ans++;
            st.Pop();
        }
        return ans;
    }
}