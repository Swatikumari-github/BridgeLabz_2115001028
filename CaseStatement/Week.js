// Input: A number between 0 and 6
let number = 3;  // You can change this to any number from 0 to 6

// Use switch-case to convert number to weekday
switch (number) {
    case 0:
        console.log("Sunday");
        break;
    case 1:
        console.log("Monday");
        break;
    case 2:
        console.log("Tuesday");
        break;
    case 3:
        console.log("Wednesday");
        break;
    case 4:
        console.log("Thursday");
        break;
    case 5:
        console.log("Friday");
        break;
    case 6:
        console.log("Saturday");
        break;
    default:
        console.log("Invalid input. Please enter a number between 0 and 6.");
        break;
}
