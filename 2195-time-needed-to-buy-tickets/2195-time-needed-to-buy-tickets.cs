public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        Queue<int> q = new();
        int times = 0;
        for(int i = 0;i<tickets.Length;i++){
            q.Enqueue(i);
        }
        while(q.Count > 0){
            int front = q.Dequeue();
            times++;
            tickets[front]--;

            if(front == k && tickets[front] == 0) return times;
            if(tickets[front] == 0) continue;
            q.Enqueue(front);
        }
        return times;
    }
}