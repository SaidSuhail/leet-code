public class Solution {
    public void DuplicateZeros(int[] arr) {
        List<int> num = new List<int>();
        foreach(int val in arr){
            num.Add(val);
            if(val == 0){
                num.Add(0);
            }
        }
        for(int i = 0;i<arr.Length;i++){
            arr[i] = num[i];
        }
    }
}