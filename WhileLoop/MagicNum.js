const readline = require("readline");

// Setup input/output interface
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Instructions for the user
console.log("Think of a number between 1 and 100, and I'll guess it!");

// Function to find the magic number
function findMagicNumber(low, high) {
    if (low > high) {
        console.log("Something went wrong. Try again!");
        rl.close();
        return;
    }

    // Find the middle number
    const mid = Math.floor((low + high) / 2);

    // Ask the user if the number is correct
    rl.question(`Is your number ${mid}? (yes/no): `, (answer) => {
        if (answer.toLowerCase() === 'yes') {
            console.log(`Yay! I found your magic number: ${mid}`);
            rl.close();
            return;
        }

        // Ask if the number is greater than mid
        rl.question(`Is your number greater than ${mid}? (yes/no): `, (response) => {
            if (response.toLowerCase() === 'yes') {
                findMagicNumber(mid + 1, high); // Search the upper half
            } else {
                findMagicNumber(low, mid - 1); // Search the lower half
            }
        });
    });
}

// Start the search between 1 and 100
findMagicNumber(1, 100);
