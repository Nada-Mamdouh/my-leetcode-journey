public class MinStack {
    Stack<long> st;
    long mini = long.MaxValue;
    public MinStack() {
        st = new Stack<long>();
    }
    
    public void Push(long val) {
        if(st.Count == 0){
            st.Push(val);
            mini = val;
        }else if(val > mini) st.Push(val);
        else{
            st.Push(2 * val - mini);
            mini = val;
        }
    }
    
    public void Pop() {
        if(st.Count == 0) return;
        else{
            long x = st.Pop();
            if(mini > x){
                mini = 2 * mini - x;
            }
        }
    }
    
    public int Top() {
        if(st.Count == 0) return -1;
        else{
            long x = st.Peek();
            if(mini < x) return (int)x;
            else return (int) mini;
        }
    }
    
    public int GetMin() {
        return (int)mini;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */