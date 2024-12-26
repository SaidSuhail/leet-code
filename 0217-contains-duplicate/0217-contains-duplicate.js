/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {
    const unique = new Set();
    for (let num of nums) {
        if (unique.has(num)) {
            return true;
        }
        unique.add(num);
    }
    return false;
};