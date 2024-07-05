public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        int pointsCount = points.Length;
        List<double> distances = new List<double>();
        Dictionary<double,List<int[]>> distanceMap = new Dictionary<double,List<int[]>>();
        for(int i = 0;i<pointsCount;i++){
            int x = points[i][0];
            int y = points[i][1];
            double distance = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
            distances.Add(distance);
            // Update distanceMap to store all points with the same distance
            if (!distanceMap.ContainsKey(distances[i])) {
                distanceMap.Add(distances[i], new List<int[]>());
            }
            distanceMap[distances[i]].Add(points[i]);
            
            
        }
        //BuildMinHeap
        BuildMinHeap(ref distances);
        int[][] res = new int[k][];
        for(int j = 0;j<k;j++){
            double closestDistance = Dequeue(ref distances);
            res[j] = distanceMap[closestDistance][0];
            distanceMap[closestDistance].RemoveAt(0);
            if(distanceMap[closestDistance].Count == 0){
                distanceMap.Remove(closestDistance);
            }
        }
        return res;
    }
    public static void BuildMinHeap(ref List<double> distances){
        for(int i = distances.Count/2-1;i>=0;i--){
            HeapifyDown(i, ref distances);
        }
    }
    public static void HeapifyDown(int idx, ref List<double> arr){
        int lastIndex = arr.Count - 1;
        
        while(true){
            int left = idx * 2 + 1;
            if(left > lastIndex) break;
            int minIdx = left;
            
            int right = left + 1;
            if(right <= lastIndex && arr[right] < arr[minIdx]){
                minIdx = right;
            }
            
            if(arr[idx] <= arr[minIdx]) break;
            swap(idx, minIdx, ref arr);
            idx = minIdx;
        }
        
    }
    public static void swap(int idx1,int idx2, ref List<double> arr){
        double tmp = arr[idx1];
        arr[idx1] = arr[idx2];
        arr[idx2] = tmp;
    }
    public static double Dequeue(ref List<double> arr){
        double root = arr[0];
        arr[0] = arr[arr.Count - 1];
        arr.RemoveAt(arr.Count - 1);
        
        HeapifyDown(0, ref arr);
        return root;
    }
}