/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function(s) {
    let words = s.split(' ');
    let reversedWords = words.map(word => word.split('').reverse().join(''));
    return reversedWords.join(' ');
};

