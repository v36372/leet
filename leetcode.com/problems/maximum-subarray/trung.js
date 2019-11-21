/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function (nums) {
    var result = Number.NEGATIVE_INFINITY;
    var sum = 0;

    for (var i = 0; i < nums.length; i++) {
        sum = Math.max(sum + nums[i] , nums[i])
        result = Math.max(sum, result)
    }

    return result
};
