/**
 * @param {string} s
 * @return {string}
 */
var sortSentence = function(s) {
    sentence = s.split(" ").sort((a,b)=>{
        return a.slice(-1)- b.slice(-1)
    })
    return sentence.join(" ").replaceAll(/[0-9]/g,"")
};