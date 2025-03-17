// Read number from command-line arguments
const number = parseInt(process.argv[2], 10);

// Function to convert number to weekday
function getWeekday(num) {
  const weekdays = [
    "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
  ];

  return num >= 1 && num <= 7 ? weekdays[num - 1] : "Invalid input";
}

console.log("Day of the week:", getWeekday(number));
