// Input: 3 numbers
let a = 5;  // Example values, you can change these
let b = 3;
let c = 2;

// Perform the arithmetic operations
let result1 = a + b * c;
let result2 = a % b + c;
let result3 = c + a / b;
let result4 = a * b + c;

// Find the maximum and minimum results
let maxResult = Math.max(result1, result2, result3, result4);
let minResult = Math.min(result1, result2, result3, result4);

// Display the results
console.log(`Result of a + b * c: ${result1}`);
console.log(`Result of a % b + c: ${result2}`);
console.log(`Result of c + a / b: ${result3}`);
console.log(`Result of a * b + c: ${result4}`);

console.log(`Maximum result: ${maxResult}`);
console.log(`Minimum result: ${minResult}`);
