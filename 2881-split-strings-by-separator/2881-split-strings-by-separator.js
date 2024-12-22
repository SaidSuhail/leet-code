/**
 * @param {string[]} words
 * @param {character} separator
 * @return {string[]}
 */
var splitWordsBySeparator = function(words, separator) {
    let result = words.map(word=>word.split(separator)).flat().filter(part => part !== "")
    return result
};