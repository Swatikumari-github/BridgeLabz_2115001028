// Function to check if a number is prime
function isPrime(num) {
    if (num <= 1) {
        return false; // Numbers less than or equal to 1 are not prime
    }

    // Check divisibility from 2 to the square root of the number
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) {
            return false; // The number is divisible by i, so it's not prime
        }
    }

    return true; // The number is prime if no divisors were found
}

// Example usage
console.log(isPrime(7));  // true (7 is prime)
console.log(isPrime(10)); // false (10 is not prime)
console.log(isPrime(1));  // false (1 is not prime)
console.log(isPrime(13)); // true (13 is prime)
