// Function to roll the die
function rollDie() {
    return Math.floor(Math.random() * 6) + 1; // Generates a number between 1 and 6
}

// Function to simulate the die rolls and store the results
function simulateDieRolls() {
    let rollResults = new Map(); // Map to store the frequency of each roll result

    // Initialize the frequency for each number (1-6) to 0 in the map
    for (let i = 1; i <= 6; i++) {
        rollResults.set(i, 0);
    }

    // Repeat the rolls until any number reaches 10 occurrences
    while (true) {
        let roll = rollDie(); // Roll the die
        let currentCount = rollResults.get(roll);
        rollResults.set(roll, currentCount + 1); // Increment the count for the rolled number

        // Check if any number has reached 10 occurrences
        if (currentCount + 1 === 10) {
            break;
        }
    }

    // Find the number with the maximum and minimum occurrences
    let maxCount = 0;
    let minCount = 10; // Start with a high value to find the minimum
    let maxNumber = null;
    let minNumber = null;

    // Iterate through the map to find the max and min counts
    for (let [num, count] of rollResults) {
        if (count > maxCount) {
            maxCount = count;
            maxNumber = num;
        }

        if (count < minCount) {
            minCount = count;
            minNumber = num;
        }
    }

    // Display the results
    console.log("Roll Results:", Object.fromEntries(rollResults)); // Convert Map to Object for display
    console.log("Number that appeared the most (max):", maxNumber, "appeared", maxCount, "times");
    console.log("Number that appeared the least (min):", minNumber, "appeared", minCount, "times");
}

// Example usage
simulateDieRolls();
