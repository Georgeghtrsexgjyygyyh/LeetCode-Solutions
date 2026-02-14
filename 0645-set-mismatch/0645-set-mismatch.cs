public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {

        int[] count = new int[nums.Length + 1];

        int dup = -1;
        int loss = -1;

        
        for (int i = 0; i < nums.Length; i++)
        {
            count[nums[i]]++;
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (count[i] == 2) dup = i;

            else if (count[i] == 0) loss = i;
        }

        return new int[] { dup, loss };
    }
}