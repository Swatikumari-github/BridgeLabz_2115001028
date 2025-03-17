// Get the command-line argument (number)
const number = parseInt(process.argv[2]);

// Validate input
if (isNaN(number) || number < 2) {
    console.error("Please provide a valid integer greater than or equal to 2.");
    process.exit(1); // Exit if input is invalid
}

// Function to compute prime factors
function primeFactors(n) {
    let factors = [];

    // Divide by 2 until n becomes odd
    while (n % 2 === 0) {
        factors.push(2);
        n = Math.floor(n / 2);
    }

    // Check for odd factors from 3 to sqrt(n)
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = Math.floor(n / i);
        }
    }

    // If n is still a prime number greater than 2
    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

// Calculate and display prime factors
const factors = primeFactors(number);
console.log(`Prime factors of ${number}: ${factors.join(' × ')}`);
