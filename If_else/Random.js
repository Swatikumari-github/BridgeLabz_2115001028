const randomNumbers = Array.from({ length: 5 }, () => Math.floor(Math.random() * 900) + 100);

console.log("Generated numbers:", randomNumbers);

// Find the minimum and maximum values
const minValue = Math.min(...randomNumbers);
const maxValue = Math.max(...randomNumbers);

console.log("Minimum value:", minValue);
console.log("Maximum value:", maxValue);