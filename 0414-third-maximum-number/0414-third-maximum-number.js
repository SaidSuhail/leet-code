/**
 * @param {number[]} nums
 * @return {number}
 */
var thirdMax = function(nums) {
    let uniquenumber = [...new Set(nums)];
    uniquenumber.sort((a,b)=>b-a);
    return uniquenumber.length>=3?uniquenumber[2]:uniquenumber[0]
};
console.log(thirdMax([3,2,1]))