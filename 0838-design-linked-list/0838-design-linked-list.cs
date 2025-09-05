public class Node{
    public int Val {get;set;}
    public Node Next {get;set;}
    public Node(int val){
        Val = val;
        Next = null;
    }
}
public class MyLinkedList {
    Node _head; //dummy head
    Node _tail; //real tail
    int _size;
    public MyLinkedList() {
        //dummy head
        _head = new Node(0);
        _tail = _head;
        _size = 0;

    }
    
    public int Get(int index) {
        if(index < 0 || index >= _size) return -1;
        Node curr = _head;
        for(int i = 0;i <= index;i++){
            curr = curr.Next;
        }
        return curr.Val;
    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        if(_size == 0){
            _head.Next = newNode;
            _tail = newNode;
        }else{
            newNode.Next = _head.Next;
            _head.Next = newNode;
        }
        _size++;
    }
    
    public void AddAtTail(int val) {
        Node newNode = new Node(val);
        _tail.Next = newNode;
        _tail = newNode;
        _size++;
    }
    
    public void AddAtIndex(int index, int val) {
        if(index < 0 || index > _size) return;
        if(index == _size){
            AddAtTail(val);
        }else if(index == 0) AddAtHead(val);
        else{
            Node newNode = new Node(val);
            Node prev = _head;
            for(int i = 0;i<index;i++){
                prev = prev.Next;
            }
            newNode.Next = prev.Next;
            prev.Next = newNode;
            _size++;
        }
    }
    
    public void DeleteAtIndex(int index) {
        if(index < 0 || index > _size) return;
        else if(index == 0) deleteAtHead();
        else if(index == _size - 1) deleteAtTail();
        else if(index > 0 && index < _size){
            Node prev = _head;
            for(int i = 0;i<index;i++){
                prev = prev.Next;
            }
            Node ToBeDeleted = prev.Next;
            prev.Next = prev.Next.Next;
            ToBeDeleted.Next = null;
            _size--; 
        }
    }
    private int GetAtTail(){
        return _tail.Val;
    }
    private void deleteAtTail(){
        if(_size != 0){
            Node prev = _head;
            while(prev.Next != _tail){
                prev = prev.Next;
            }
            prev.Next = null;
            _tail = prev;
            _size--;
        }
    }
    private void deleteAtHead(){
        if(_size == 0) return;
        if(_size == 1){
            _head.Next = null;
            _tail = _head;
        }else{
            Node nodetobed = _head.Next;
            _head.Next = _head.Next.Next;
            nodetobed.Next = null;
        }
        _size--;
    }
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