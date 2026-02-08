public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> visited = new HashSet<int>();

        foreach (int x in nums) 
        {
            if (!visited.Add(x)) return true;
        }

        return false;
    }
}