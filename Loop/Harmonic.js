// Get the command-line argument (n)
const n = parseInt(process.argv[2]);

// Validate the input
if (isNaN(n) || n <= 0) {
    console.error("Please provide a valid positive integer.");
    process.exit(1); // Exit the program for invalid input
}

// Calculate the n-th harmonic number
let harmonic = 0;
for (let i = 1; i <= n; i++) {
    harmonic += 1 / i; // Add the reciprocal of each natural number
    console.log(`1/${i}`); // Display each term
}

// Output the result
console.log(`\nThe ${n}th harmonic number is: ${harmonic}`);
