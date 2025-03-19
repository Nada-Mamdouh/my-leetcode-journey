public class Solution {
    public string RemoveKdigits(string num, int k) {
        Stack<char> st = new();
        //Normal traversal - 1- TC: O(n)
        for(int i = 0;i<num.Length;i++){
            while(st.Count > 0 && k> 0 && st.Peek()-'0' > num[i]-'0'){
                st.Pop();
                k--;
            }
            st.Push(num[i]);
        }
        //If the elements were sorted ascending and no removal happenend
        //Then remove the greatest values from TOS

        //2 - TC: O(k)
        while(k > 0 && st.Count > 0){
            st.Pop();
            k--;
        }
        //If all the elements were removed 
        if(st.Count == 0){
            return "0";
        }
        //group characters together
        //3- TC: O(n)
        char[] ans = new char[st.Count];
        int j = 0;
        while(st.Count > 0){
            ans[j++] = st.Pop();
        }
        //4- TC: O(n-k)
        Reverse(ref ans);
        //5- TC: O(n-k)
        string val = new String(ans);
        for(int i = 0;i<ans.Length;i++){
            if(ans[i] != '0'){
                val = val.Substring(i);
                break;
            }
        }
        return val[0] != '0' && val.Length > 0? val: "0";

    }
    void Reverse(ref char[] arr){
        int i = 0, j = arr.Length -1;
        while(j > i){
            char tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
            i++; j--;
        }
    }

}