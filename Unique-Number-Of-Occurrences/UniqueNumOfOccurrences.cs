public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var occ = new Dictionary<int, int>();
        HashSet<int> uniqueOccurrences = new HashSet<int>();

        foreach(var i in arr){
            if(occ.ContainsKey(i)){
                occ[i] += 1;
            } else {
                occ[i] = 1;
            }
        }
        foreach(var count in occ.Values){
            if(!uniqueOccurrences.Add(count)){
                return false;
            }
        }
        return true;
    }
}