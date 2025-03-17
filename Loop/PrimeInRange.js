// Get the command-line arguments (start and end of range)
const start = parseInt(process.argv[2]);
const end = parseInt(process.argv[3]);

// Validate input
if (isNaN(start) || isNaN(end) || start < 2 || end < 2 || start > end) {
    console.error("Please enter a valid range where both numbers are integers ≥ 2, and start ≤ end.");
    process.exit(1); // Exit if input is invalid
}

// Function to check if a number is prime
function isPrime(number) {
    if (number < 2) return false; // Exclude numbers less than 2
    for (let i = 2; i <= Math.sqrt(number); i++) {
        if (number % i === 0) return false; // Not prime if divisible
    }
    return true; // Prime if no divisors found
}

// Find and print prime numbers in the range
console.log(`Prime numbers between ${start} and ${end}:`);

for (let i = start; i <= end; i++) {
    if (isPrime(i)) {
        console.log(i); // Output prime numbers
    }
}
