public class MinStack {
    List<int> data;
    List<int> mins;

    public MinStack() {
        data = new List<int>();
        mins = new List<int>();
    }
    
    public void Push(int val) {
       data.Add(val);
       if(mins.Count == 0 || val <= mins[mins.Count -1]){
           mins.Add(val);
       }
    }
    
    public void Pop() {
        if(data.Count == 0) return;
        var topValue = data[data.Count - 1];
        data.RemoveAt(data.Count -1);
        if(mins[mins.Count -1] == topValue){
            mins.RemoveAt(mins.Count -1 );
        }
    }
    
    public int Top() {
        return data[data.Count -1];
    }
    
    public int GetMin() {
        return mins[mins.Count -1];
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