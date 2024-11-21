/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var searchRange = function(nums, target) {
    const firstindex = nums.indexOf(target);
    const lastindex = nums.lastIndexOf(target);
    return [firstindex,lastindex];
};
console.log(searchRange([5,7,7,8,8,10],8));