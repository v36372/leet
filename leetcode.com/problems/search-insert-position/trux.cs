public class Solution {
  public int SearchInsert(int[] nums, int target) {
             int left = 0;
            int right = nums.Length - 1;
            if(nums[nums.Length - 1] < target)
            {
                return nums.Length;
            }
            if(nums[0] > target)
            {
                return 0;
            }
            while (left <= right) {
                int mid = (left + right) / 2;
                if (target == nums[mid]) 
                    return mid;
                else if (target < nums[mid]) 
                    right = mid - 1;
                else if (target > nums[mid]) 
                    left = mid + 1;
                } 
            if(nums[left] < target)
            {
                return left +1;
            }else{
                return left ;
            }
        
        
        }
}