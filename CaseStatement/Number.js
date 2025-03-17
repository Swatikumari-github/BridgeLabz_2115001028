// Input: A number like 1, 10, 100, 1000, etc.
let number = 1000;  // You can change this to any number like 1, 10, 100, 1000

// Convert number to string to easily check its length
let numberString = number.toString();

// Determine the place value based on the length of the number
switch (numberString.length) {
    case 1:
        console.log("unit");
        break;
    case 2:
        console.log("ten");
        break;
    case 3:
        console.log("hundred");
        break;
    case 4:
        console.log("thousand");
        break;
    case 5:
        console.log("ten thousand");
        break;
    case 6:
        console.log("hundred thousand");
        break;
    case 7:
        console.log("million");
        break;
    default:
        console.log("Number too large or invalid input");
        break;
}
