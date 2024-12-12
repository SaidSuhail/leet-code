/**
 * @param {number} n
 * @return {number}
 */
var subtractProductAndSum = function(n) {
    const digits = n.toString().split('').map(Number);
    const product = digits.reduce((sum,num)=>sum*num,1);
    const sum = digits.reduce((sum,num)=>sum+num,0)
    return product-sum
};