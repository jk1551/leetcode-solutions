public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers.Length == 2){
            return [1, 2];
        }
        
        var left = 0;
        var right = numbers.Length - 1;

        while(left < right) {
            if((numbers[left] + numbers[right]) > target){
                right -= 1;
            }

            if((numbers[left] + numbers[right]) < target){
                left += 1;
            }

            if((numbers[left] + numbers[right]) == target){
                return[left + 1, right + 1];
            }
        }

        return [];
    }
}