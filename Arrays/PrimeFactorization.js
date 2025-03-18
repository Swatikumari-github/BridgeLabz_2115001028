// Function to get the prime factors of a number
function primeFactorization(n) {
    let factors = []; // Array to store prime factors

    // Check for the number of 2s that divide n
    while (n % 2 === 0) {
        factors.push(2); // Add 2 to the factors array
        n /= 2;
    }

    // Now, n must be odd at this point. Start from 3 and check odd numbers.
    for (let i = 3; i * i <= n; i += 2) {
        // While i divides n, add i to the factors array
        while (n % i === 0) {
            factors.push(i); // Add i to the factors array
            n /= i;
        }
    }

    // If n is a prime number greater than 2, add it to the factors array
    if (n > 2) {
        factors.push(n);
    }

    return factors; // Return the array containing the prime factors
}

// Example usage
let number = 60; // You can change this number to any integer
let primeFactors = primeFactorization(number);

console.log(`Prime Factors of ${number}:`, primeFactors);
