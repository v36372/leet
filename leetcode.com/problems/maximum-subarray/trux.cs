public class Solution {
    public int MaxSubArray(int[] nums) {
        int nextSum = nums[0];
        int result = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            nextSum = (nextSum + nums[i]) > nums[i] ? nextSum + nums[i] : nums[i];
            result = (nextSum > result) ? nextSum : result;
        }
        return result;
    }
}