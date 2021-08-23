var isValid = function(s) {
    //string to array
    let array = [];
    
    let loop = 0, prev = 0;

    for(let i = 0; i< s.length; i++) {
        if (s[i] === '(') {
            array.push(')');
        } else if (s[i] === '{') {
            array.push('}');
        } else if (s[i] === '[') {
            array.push(']');
        }  else if (array.length === 0 || array.pop() !== s[i]) {
            return false;
        }
        
        
    };
    return array.length === 0;
}

console.log(isValid('([({})]){}'))