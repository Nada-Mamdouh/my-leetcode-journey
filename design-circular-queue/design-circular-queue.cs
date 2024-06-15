public class MyCircularQueue {
    private int[] dataQ;
    private int front;
    private int tail;
    private int count;
    public MyCircularQueue(int k) {
        //dataQ = new List<int>();
        dataQ = new int[k];
        front = -1;
        tail = -1;
        count = 0;
    }
    
    public bool EnQueue(int value) {
        if(IsFull()) return false;
        if(tail == -1){
            front = 0;
        }
        tail++;
        if(tail == dataQ.Length){
            tail = 0;
        }
        
        dataQ[tail] = value;
        count++;
        return true;
    }
    
    public bool DeQueue() {
        if(IsEmpty()) return false;
        front++;
        if(front == dataQ.Length) front = 0;
        count--;
        return true;
    }
    
    public int Front() {
        if(IsEmpty()) return -1;
        return dataQ[front];
    }
    
    public int Rear() {
        if(IsEmpty()) return -1;
        return dataQ[tail];
    }
    
    public bool IsEmpty() {
        return (front == -1 && tail == -1) || count == 0;
    }
    
    public bool IsFull() {
        // if(front == 0 && tail == dataQ.Length -1 ) return true;
        return count == dataQ.Length;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */