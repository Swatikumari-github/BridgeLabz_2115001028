// Step a: Generates 10 Random 3-digit numbers
let numbers = [];
for (let i = 0; i < 10; i++) {
    numbers.push(Math.floor(Math.random() * 900) + 100); // Random number between 100 and 999
}

// Step b: Store the random numbers in an array
console.log("Generated Numbers:", numbers);

// Step d: Sort the array in ascending order
numbers.sort((a, b) => a - b);
console.log("Sorted Numbers:", numbers);

// Step e: Find the 2nd smallest and 2nd largest element
let secondSmallest = numbers[1]; // Second smallest is at index 1
let secondLargest = numbers[numbers.length - 2]; // Second largest is at the second last index

console.log("Second Smallest:", secondSmallest);
console.log("Second Largest:", secondLargest);
