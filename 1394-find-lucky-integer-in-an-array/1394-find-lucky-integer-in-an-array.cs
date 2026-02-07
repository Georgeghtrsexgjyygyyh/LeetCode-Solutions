public class Solution
{
    public int FindLucky(int[] arr)
    {
        
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int x in arr)
        {
            if (map.ContainsKey(x)) map[x]++;
            else map[x] = 1;
        }

        int maxn = -1; 

        foreach (int x in map.Keys)
        {
            
            if (x == map[x])
            {
                maxn = maxn > x ? maxn : x;
            }
        }

        return maxn;
    }
}