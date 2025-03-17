const readline = require('readline');

// Create an interface for reading input from the terminal
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Ask the user for the conversion type
rl.question("Enter the type of conversion (1: Feet to Inch, 2: Feet to Meter, 3: Inch to Feet, 4: Meter to Feet): ", function(conversionType) {
    // Ask the user for the length to convert
    rl.question("Enter the length to convert: ", function(length) {
        length = parseFloat(length);  // Convert length to a floating point number

        // Perform the conversion based on user's choice
        switch (conversionType) {
            case '1':
                // Feet to Inch
                let feetToInch = length * 12;
                console.log(`${length} feet is equal to ${feetToInch} inches.`);
                break;

            case '2':
                // Feet to Meter
                let feetToMeter = length * 0.3048;
                console.log(`${length} feet is equal to ${feetToMeter} meters.`);
                break;

            case '3':
                // Inch to Feet
                let inchToFeet = length / 12;
                console.log(`${length} inches is equal to ${inchToFeet} feet.`);
                break;

            case '4':
                // Meter to Feet
                let meterToFeet = length * 3.28084;
                console.log(`${length} meters is equal to ${meterToFeet} feet.`);
                break;

            default:
                console.log("Invalid conversion type. Please enter a number between 1 and 4.");
                break;
        }

        // Close the readline interface after conversion
        rl.close();
    });
});
