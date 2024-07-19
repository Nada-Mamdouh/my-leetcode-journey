public class MyHashSet {
    List<int> container;
    public MyHashSet() {
        container = new List<int>();
    }
    
    public void Add(int key) {
        if(!this.Contains(key)){
            container.Add(key);
        }
    }
    
    public void Remove(int key) {
        if(this.Contains(key)){
            container.Remove(key);
        }
    }
    
    public bool Contains(int key) {
        this.container.Sort();
        int left = 0, right = this.container.Count-1;
        while(left <= right){
            int mid = (left+right)/2;
            if(this.container[mid] == key){
                return true;
            }else if(this.container[mid] > key){
                right = mid - 1;
            }else{
                left = mid + 1;
            }
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */