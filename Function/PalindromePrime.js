// Function to check if a number is prime
function isPrime(num) {
    if (num <= 1) {
        return false; // Numbers less than or equal to 1 are not prime
    }

    // Check divisibility from 2 to the square root of the number
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) {
            return false; // Number is divisible by i, so it's not prime
        }
    }

    return true; // Number is prime if no divisors are found
}

// Function to get the palindrome of a number
function getPalindrome(num) {
    let str = num.toString();  // Convert the number to a string
    let reversedStr = str.split('').reverse().join('');  // Reverse the string
    return parseInt(reversedStr);  // Convert the reversed string back to a number
}

// Function to check if the palindrome of a number is prime
function checkPalindromePrime(num) {
    let palindrome = getPalindrome(num);
    console.log(`Palindrome of ${num} is ${palindrome}`);
    
    // Check if the palindrome is prime
    if (isPrime(palindrome)) {
        console.log(`${palindrome} is also a prime number.`);
    } else {
        console.log(`${palindrome} is not a prime number.`);
    }
}

// Example usage: Test the number 131
checkPalindromePrime(131); // Palindrome is 131, check if it's prime
checkPalindromePrime(123); // Palindrome is 321, check if it's prime
