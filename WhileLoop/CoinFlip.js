// Function to simulate a coin flip
function flipCoin() {
    return Math.random() < 0.5 ? "Heads" : "Tails";
}

// Initialize counters
let headsCount = 0;
let tailsCount = 0;

// Loop until either Heads or Tails reaches 11 wins
while (headsCount < 11 && tailsCount < 11) {
    const result = flipCoin();
    console.log(`Coin flip: ${result}`);
    
    if (result === "Heads") {
        headsCount++;
    } else {
        tailsCount++;
    }

    console.log(`Score -> Heads: ${headsCount}, Tails: ${tailsCount}`);
}

// Announce the winner
if (headsCount === 11) {
    console.log("🎉 Heads wins 11 times!");
} else {
    console.log("🎊 Tails wins 11 times!");
}
