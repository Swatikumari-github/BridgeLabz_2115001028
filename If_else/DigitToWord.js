const number = parseInt(process.argv[3], 10);

function numberToWord(num) {
  const words = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
  return num >= 0 && num <= 9 ? words[num] : "Invalid input";
}

console.log("Number in word:", numberToWord(number));