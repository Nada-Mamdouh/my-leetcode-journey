public class NumArray {
    int[] Nums;
    int[] prefix_sum;
    int n;
    public NumArray(int[] nums) {
        Nums = nums;
        n = nums.Length;
        prefix_sum = new int[n];
        PopulatePreSum();
    }
    
    public int SumRange(int left, int right) {
        if(left == 0) return prefix_sum[right];
        return prefix_sum[right] - prefix_sum[left - 1];
    }
    void PopulatePreSum(){
        int summ = 0;
        for(int i = 0;i<n;i++){
            summ+=Nums[i];
            prefix_sum[i] = summ;
        }
        foreach(var item in prefix_sum){
            Console.WriteLine(item);
        }
    }

}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */