function displayPlaceValue(number) {
    const placeValues = ["unit", "ten", "hundred", "thousand", "ten thousand", "hundred thousand", "million"];
    
    let numberString = number.toString();
    let length = numberString.length;

    // If number is less than 1, no valid place value
    if (number === 0) {
        console.log("unit");
        return;
    }
    
    // Display the place value
    console.log(placeValues[length - 1] || "unknown");
}