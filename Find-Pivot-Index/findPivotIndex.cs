public class Solution {
    public int PivotIndex(int[] nums) {
        int left = 0;
        int right = 0;

        // Calculate the sum of the the integer array - index 0
        for(var i = 0; i < nums.Length; i++){
            right += nums[i];
        }
        
        // Compare left vs right for each index
        for(var i = 0; i < nums.Length; i++){
            right -= nums[i];

            if(left == right){
                return i;
            }
            left += nums[i];
        }

        return -1;
    }
}