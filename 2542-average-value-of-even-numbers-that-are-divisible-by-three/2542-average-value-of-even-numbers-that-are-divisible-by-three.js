/**
 * @param {number[]} nums
 * @return {number}
 */
var averageValue = function(nums) {
    let filter = nums.filter(x=>x%2 === 0 && x%3 ===0);

    let result = filter.reduce((x,i) => x+i,0);

    let finale = filter.length > 0 ? Math.floor(result / filter.length) : 0;
    return finale;
};
