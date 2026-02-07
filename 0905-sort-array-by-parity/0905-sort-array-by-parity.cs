public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) 
        {
            if (nums[left] % 2 != 0 && nums[right] % 2 == 0) 
            {
                int leftn = nums[left];

                nums[left] = nums[right];
                nums[right] = leftn;
                
            }
            
            if(nums[left] % 2 == 0) 
            {
                left++;
            }

            if (nums[right] % 2 != 0)
            {
                right--;
            }



        }

        return nums;
    }
}
