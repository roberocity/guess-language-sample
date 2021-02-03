const readline = require("readline");

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

const getRandom = (min, max) => {
    return Math.floor((Math.random() * max) % max + min);
}

const min = 1
const max = process.argv[2] || 1000
const number = getRandom(min, max)

console.log(`I have selected a number between ${min} and ${max}.`)
console.log('Please guess my number.')

let guessCount = 0;

const askUser = () => {
    rl.question('Your guess: ', (n) => {
        guessCount ++;

        if (n == number) {
            console.log(`You guessed my number in ${guessCount} guesses.`)
            process.exit()
        } 
        else if (n < number) {
            console.log('Too low. Try again.');
            askUser();
        }
        else {
            console.log('Too high. Try again.')
            askUser();
        }
    })
}

askUser();
