public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int result = (nums.Length * (nums.Length + 1) / 2) - nums.Sum();

        return result;
    }
}