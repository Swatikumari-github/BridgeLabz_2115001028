const year = parseInt(process.argv[2], 10);

function isLeapYear(year) {
  if (year < 1000 || year > 9999) {
    return "Please enter a 4-digit year.";
  }
  if ((year % 4 === 0 && year % 100 !== 0) || year % 400 === 0) {
    return "Leap Year";
  }
  return "Not a Leap Year";
}

console.log(isLeapYear(year));
