public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int result = 0;

        foreach(var num in nums){
            if(count.ContainsKey(num)){
                result += count[num];
                count[num] += 1;
            } else {
                count[num] = 1;
            }
        } 
        return result;
    }
}