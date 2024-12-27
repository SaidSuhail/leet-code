/**
 * @param {number[]} nums
 * @return {number}
 */
var sumOfUnique = function (nums) {
    const unique = [...new Set(nums.filter(num => nums.indexOf(num) === nums.lastIndexOf(num)))]
    return unique.reduce((sum, num) => sum + num, 0)


};