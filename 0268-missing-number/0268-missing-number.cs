public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int expSum = nums.Length * (nums.Length + 1) / 2;

        int actSum = 0;

        
        for (int i = 0; i < nums.Length; i++)
        {
            actSum += nums[i];
        }

        return expSum - actSum;
    
    }
}