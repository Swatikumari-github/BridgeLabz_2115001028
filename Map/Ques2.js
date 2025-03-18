// Function to generate a random birth month (between 1 and 12)
function generateRandomMonth() {
    return Math.floor(Math.random() * 12) + 1;
}

// Function to simulate the birth month of 50 individuals and store them
function generateBirthMonths() {
    let birthMonths = new Map(); // Map to store individuals grouped by their birth month

    // Generate birth month for 50 individuals
    for (let i = 1; i <= 50; i++) {
        let month = generateRandomMonth(); // Get a random birth month
        if (!birthMonths.has(month)) {
            birthMonths.set(month, []); // Initialize an empty array if the month is not in the map
        }
        birthMonths.get(month).push(i); // Add the individual to the corresponding month
    }

    return birthMonths;
}

// Function to display the individuals grouped by birth month
function displayBirthMonthGroups() {
    let birthMonths = generateBirthMonths();

    // Print the individuals grouped by their birth month
    console.log("Individuals grouped by their birth month:");
    for (let [month, individuals] of birthMonths) {
        console.log(`Month ${month}: Individuals with IDs ${individuals.join(', ')}`);
    }
}

// Example usage
displayBirthMonthGroups();
