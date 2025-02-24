/**
 * @param {string[]} sentences
 * @return {number}
 */
var mostWordsFound = function(sentences) {
    const numbers = sentences.map(sentence => sentence.split(" ").length);
    return Math.max(...numbers);
};