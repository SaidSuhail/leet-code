/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let element = nums.sort();
    return element[Math.floor(nums.length/2)]
};