/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function(nums) {
  return nums.reduce((sum,num)=>sum^num,0)  
};