public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
        for (int i = 0; i < n+1; i++)
            ans[i] = Convert.ToString(i, 2).Count(x => x == '1');
        return ans;
    }
}