public class Solution {
    public int FindLucky(int[] arr) {
        
        Dictionary<int, int> map = new Dictionary<int, int>(arr.Length);

        foreach (int x in arr) {
           
            map.TryGetValue(x, out int count);
            map[x] = count + 1;
        }

        int maxn = -1;

        
        foreach (var pair in map) {
            if (pair.Key == pair.Value) {
                if (pair.Key > maxn) maxn = pair.Key;
            }
        }

        return maxn;
    }
}