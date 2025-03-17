// Function to check if a number is a palindrome
function isPalindrome(num) {
    let str = num.toString();  // Convert number to string
    let reversedStr = str.split('').reverse().join('');  // Reverse the string
    return str === reversedStr;  // Compare original string with reversed string
}

// Function to check if two numbers are palindromes
function checkIfBothArePalindromes(num1, num2) {
    const isNum1Palindrome = isPalindrome(num1);
    const isNum2Palindrome = isPalindrome(num2);

    if (isNum1Palindrome && isNum2Palindrome) {
        console.log(`${num1} and ${num2} are both palindromes.`);
    } else if (isNum1Palindrome) {
        console.log(`${num1} is a palindrome but ${num2} is not.`);
    } else if (isNum2Palindrome) {
        console.log(`${num2} is a palindrome but ${num1} is not.`);
    } else {
        console.log(`${num1} and ${num2} are both not palindromes.`);
    }
}

// Example usage
checkIfBothArePalindromes(121, 1221);  // Both are palindromes
checkIfBothArePalindromes(123, 121);  // 121 is palindrome, 123 is not
checkIfBothArePalindromes(123, 456);  // Neither is palindrome
