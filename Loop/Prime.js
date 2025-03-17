// Get the command-line argument (number)
const number = parseInt(process.argv[2]);

// Validate input
if (isNaN(number) || number < 2) {
    console.error("Please enter a valid integer greater than or equal to 2.");
    process.exit(1); // Exit if input is invalid
}

// Function to check if the number is prime
let isPrime = true;

// Only check divisibility up to the square root of the number
for (let i = 2; i <= Math.sqrt(number); i++) {
    if (number % i === 0) {
        isPrime = false; // Not a prime number
        break;
    }
}

// Output the result
if (isPrime) {
    console.log(`${number} is a prime number.`);
} else {
    console.log(`${number} is NOT a prime number.`);
}
