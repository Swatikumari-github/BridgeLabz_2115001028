// Function to get the palindrome of a number
function getPalindrome(num) {
    let str = num.toString();  // Convert the number to a string
    let reversedStr = str.split('').reverse().join('');  // Reverse the string
    return parseInt(reversedStr);  // Convert the reversed string back to a number
}

// Example usage
console.log(getPalindrome(123));  // 321
console.log(getPalindrome(4567)); // 7654
console.log(getPalindrome(121));  // 121
