public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int[] numsd = nums.Distinct().ToArray();

        int numsdsum = numsd.Sum();

        int sumreal = nums.Length * (nums.Length + 1) / 2;

        int[] newn = { nums.Sum() - numsdsum, sumreal - numsdsum};

        return newn;
    }
}