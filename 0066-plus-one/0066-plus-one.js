/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function(digits) {
    const Str =  digits.join('');
    const increment = (BigInt(Str)+BigInt(1)).toString()
    return increment.split('').map(Number)
};
