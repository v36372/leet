public int ThreeSumClosest(int[] nums, int target)
{

    int result = 0;
    Array.Sort(nums);
    int tempMin = int.MaxValue;
    for (int i = 0; i < nums.Length; i++)
    {
        int left = i + 1;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[i] + nums[left] + nums[right];
            int diff = Math.Abs(sum - target);

            if (diff == 0)
                return sum;
            if (diff < tempMin)
            {
                tempMin = diff;
                result = sum;
            }
            if (sum <= target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }
    return result;
}