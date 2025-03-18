function findRepeatedDigits() {
    let result = [];
    
    // Loop through the numbers from 0 to 100
    for (let i = 0; i <= 100; i++) {
        // Convert number to a string to check its digits
        let numStr = i.toString();

        // Check if the number has two digits and both are the same
        if (numStr.length === 2 && numStr[0] === numStr[1]) {
            result.push(i);
        }
    }
    
    return result;
}

// Example usage
let repeatedDigits = findRepeatedDigits();
console.log("Numbers with repeated digits:", repeatedDigits);
