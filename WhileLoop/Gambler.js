// Function to simulate a bet: 50-50 chance for win or loss
function placeBet() {
    return Math.random() < 0.5 ? "Win" : "Loss";
}

// Initialize the gambler's starting amount and counters
let money = 100;
let goal = 200;
let betCount = 0;
let winCount = 0;

// Keep gambling until the gambler is broke or reaches the goal
while (money > 0 && money < goal) {
    betCount++; // Increment bet counter
    const result = placeBet();

    if (result === "Win") {
        money++; // Increase by Rs 1 if won
        winCount++; // Increment win counter
    } else {
        money--; // Decrease by Rs 1 if lost
    }

    // Output the current status after each bet
    console.log(`Bet ${betCount}: ${result} | Current Money: Rs ${money}`);
}

// Output the final result
if (money >= goal) {
    console.log(`🎉 Congratulations! You reached Rs 200 in ${betCount} bets with ${winCount} wins!`);
} else {
    console.log(`😔 You went broke after ${betCount} bets with ${winCount} wins.`);
}
