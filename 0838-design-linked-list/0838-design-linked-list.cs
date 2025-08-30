public class MyLinkedList {
    int[] arr;
    int size;
    int capacity = 1;
    public MyLinkedList() {
        arr = new int[capacity];
        size = 0;
    }
    
    public int Get(int index) {
        if(size == 0 || index >= size) return -1;
        return arr[index];
    }
    
    public void AddAtHead(int val) {
        AddAtIndex(0, val);
    }
    
    public void AddAtTail(int val) {
        AddAtIndex(size, val);
    }
    
    public void AddAtIndex(int index, int val) {
        if(size == capacity) resize(capacity * 2);
        if(index < capacity){
            for(int i = size;i > index;i--){
                arr[i] = arr[i-1];
            }
            arr[index] = val;
            size++;
        }
    }
    
    public void DeleteAtIndex(int index) {
        if(index >= 0 && index < size){
            for(int i = index; i<size-1;i++){
                arr[i] = arr[i+1];
            }
            size--;
            if(size != 0 && capacity > 1 && size == capacity/4) resize(capacity / 2);
        }
        
    }
    void resize(int newCapacity){
        int[] newArr = new int[newCapacity];
        for(int i = 0;i<size;i++){
            newArr[i] = arr[i];
        }
        capacity = newCapacity;
        arr = newArr;
    }
    private bool IsEmpty() => size == 0;
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */