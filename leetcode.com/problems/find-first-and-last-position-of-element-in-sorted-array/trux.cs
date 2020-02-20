public class Solution {
   public int[] SearchRange(int[] nums, int target) {
            var resultLeft = -1;
            var resultRight = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                var left = nums.Length - 1 - i;
                if(nums[i] == target && resultLeft == -1)
                {
                     resultLeft = i;
                }
                if(nums[left] == target && resultRight == -1)
                {
                   resultRight = left;
                }
                if(resultLeft != -1 && resultRight != -1)
                {
                    break;
                }
            }
            return new int[] { resultLeft , resultRight};
        }
}