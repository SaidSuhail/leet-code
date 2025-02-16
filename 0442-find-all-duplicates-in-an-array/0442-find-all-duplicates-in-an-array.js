/**
 * @param {number[]} nums
 * @return {number[]}
 */
/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDuplicates = function (nums) {
    const unique = new Set();
    const result = [];
    for (const num of nums) {
        if (unique.has(num)) {
            result.push(num)
        } else {
            unique.add(num)
        }
    }
    return result
};