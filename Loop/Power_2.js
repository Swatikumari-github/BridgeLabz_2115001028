// Get the command-line argument (n)
const n = parseInt(process.argv[2]);

// Check if n is a valid number
if (isNaN(n) || n < 0) {
    console.log("Please provide a valid non-negative integer.");
    process.exit(1);  // Exit the program if input is invalid
}

// Print the header for the table
console.log(`Powers of 2 up to 2^${n}:\n`);

// Loop through from 0 to n and print the powers of 2
for (let i = 0; i <= n; i++) {
    console.log(`2^${i} = ${Math.pow(2, i)}`);
}
