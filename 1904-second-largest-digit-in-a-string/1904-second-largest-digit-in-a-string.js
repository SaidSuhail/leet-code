/**
 * @param {string} s
 * @return {number}
 */
var secondHighest = function(s) {
    let digits=s.replaceAll(/[a-z]/g, "").split("").map(Number);
    let uniqueDigits = [...new Set(digits)];
     uniqueDigits.sort((a, b) => b - a); 
     return uniqueDigits[1] !== undefined ? uniqueDigits[1] : -1;
};