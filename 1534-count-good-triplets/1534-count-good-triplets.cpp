class Solution {
public:
    int countGoodTriplets(vector<int>& arr, int a, int b, int c) {
        int n = arr.size();
        int cnt = 0;
        for(int i = 0;i<n;i++){
            for(int j = 0; j<n;j++){
                for(int k = 0;k<n;k++){
                    if( i < j && j < k && abs(arr[i] - arr[j]) <= a && abs(arr[j] - arr[k]) <= b && abs(arr[i] - arr[k]) <= c){
                        cnt++;
                    }
                }
            }
        }
        return cnt;
    }
};