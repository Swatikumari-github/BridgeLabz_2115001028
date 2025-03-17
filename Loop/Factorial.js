// Get the command-line argument (number)
const number = parseInt(process.argv[2]);

// Validate input
if (isNaN(number) || number < 0) {
    console.error("Please provide a valid non-negative integer.");
    process.exit(1); // Exit if input is invalid
}

// Function to calculate factorial
function factorial(n) {
    let result = 1;
    for (let i = 1; i <= n; i++) {
        result *= i; // Multiply result by each number up to n
    }
    return result;
}

// Calculate and output the factorial
console.log(`${number}! = ${factorial(number)}`);
