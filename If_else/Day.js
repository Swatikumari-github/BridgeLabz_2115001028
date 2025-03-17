const day = parseInt(process.argv[2], 10);
const month = parseInt(process.argv[3], 10);

function isBetweenMarch20AndJune20(day, month) {
  if (month === 3 && day >= 20) return true; // March 20 or later
  if (month === 4 || month === 5) return true; // April and May
  if (month === 6 && day <= 20) return true; // June 20 or earlier
  return false;
}

console.log(isBetweenMarch20AndJune20(day, month));
