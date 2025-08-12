public class Solution {
    public int CountTriples(int n) {
          int count = 0;
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= n; j++) {
                int kSquared = i * i + j * j;
                int k = (int)Math.Sqrt(kSquared);
                if (k * k == kSquared && k <= n) {
                    count++;
                }
            }
        }
        return count;
    }
}