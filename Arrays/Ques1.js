// Step a: Generates 10 Random 3-digit numbers
let numbers = [];
for (let i = 0; i < 10; i++) {
    numbers.push(Math.floor(Math.random() * 900) + 100); // Random number between 100 and 999
}

// Step b: Store the random numbers in an array
console.log("Generated Numbers:", numbers);

// Step c: Find the 2nd largest and 2nd smallest element without sorting the array
let smallest = Infinity;
let secondSmallest = Infinity;
let largest = -Infinity;
let secondLargest = -Infinity;

for (let num of numbers) {
    // Finding the smallest and second smallest
    if (num < smallest) {
        secondSmallest = smallest;
        smallest = num;
    } else if (num < secondSmallest && num !== smallest) {
        secondSmallest = num;
    }

    // Finding the largest and second largest
    if (num > largest) {
        secondLargest = largest;
        largest = num;
    } else if (num > secondLargest && num !== largest) {
        secondLargest = num;
    }
}

console.log("Second Largest:", secondLargest);
console.log("Second Smallest:", secondSmallest);
