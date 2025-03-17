// Include the readline module for user input
const readline = require('readline');
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to display the menu and prompt user for conversion choice
function showMenu() {
    console.log("\nChoose the type of conversion:");
    console.log("1: Celsius to Fahrenheit");
    console.log("2: Fahrenheit to Celsius");
}

// Function to perform the conversion
function convertTemperature() {
    showMenu();

    // Prompt the user for their conversion choice
    rl.question("Enter the conversion choice (1 or 2): ", (choice) => {
        // Validate the input
        if (choice !== '1' && choice !== '2') {
            console.log("Invalid choice. Please enter 1 or 2.");
            rl.close();
            return;
        }

        // Ask for the temperature value
        rl.question("Enter the temperature value: ", (tempValue) => {
            let temp = parseFloat(tempValue);
            
            // Check if the entered temperature is within valid range
            if (temp < 0 || temp > 100) {
                console.log("Temperature out of valid range! Please enter a value between 0 and 100.");
                rl.close();
                return;
            }

            let result;

            switch(choice) {
                case '1': // Celsius to Fahrenheit
                    result = (temp * 9/5) + 32;
                    console.log(`${temp}°C is equal to ${result.toFixed(2)}°F.`);
                    break;
                case '2': // Fahrenheit to Celsius
                    result = (temp - 32) * 5/9;
                    console.log(`${temp}°F is equal to ${result.toFixed(2)}°C.`);
                    break;
            }

            rl.close();
        });
    });
}

// Start the conversion process
convertTemperature();
