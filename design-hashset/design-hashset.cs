public class MyHashSet {
    bool[] container;
    public MyHashSet() {
        container = new bool[1000001];
    }
    
    public void Add(int key) {
        if(!this.Contains(key)){
            container[key] = true;
        }
    }
    
    public void Remove(int key) {
        if(this.Contains(key)){
            container[key] = false;
        }
    }
    
    public bool Contains(int key) {
        return container[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */