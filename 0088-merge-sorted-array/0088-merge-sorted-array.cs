using System.Linq;
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
          var filterednum = nums1.Take(m).ToArray();
        var result = filterednum.Concat(nums2).OrderBy(x=>x).ToArray();
           for (int i = 0; i < result.Length; i++) {
            nums1[i] = result[i];
        }
        
             Console.WriteLine("Merged result:");
            foreach (var num in nums1.Take(result.Length)) {
            Console.Write(num + " ");
        }
    }
}