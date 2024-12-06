/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersection = function(nums1, nums2) {
    return [...new Set(nums1)].filter(num1 => nums2.includes(num1));
};
const num1 = [1,2,2,1];
const num2 = [2,2];
console.log(intersection(num1,num2));