// Get the command-line argument (n)
const n = parseInt(process.argv[2]);

// Validate input
if (isNaN(n) || n < 0) {
    console.error("Please provide a valid non-negative integer.");
    process.exit(1); // Exit if input is invalid
}

// Print the table of powers of 2
console.log(`Table of powers of 2 up to 2^${n} (maximum 256):`);

let power = 1; // Start from 2^0
for (let i = 0; i <= n; i++) {
    console.log(`2^${i} = ${power}`);
    power *= 2; // Next power of 2

    // Stop if the value exceeds 256
    if (power > 256) break;
}
