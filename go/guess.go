package main

import (
	"fmt"
	"log"
	"math/rand"
	"os"
	"strconv"
)

func main() {
	min, max := 1, 1000

	if len(os.Args) > 1 {
		i, err := strconv.Atoi(os.Args[1])
		if err != nil {
			log.Panic(err)
		}
		max = i
	}

	number := rand.Intn(max-1) + min

	fmt.Printf("I have select a number between %d and %d.\n", min, max)
	fmt.Println("Pleast try to guess my number.")

	guessCount := 0

	for {
		var guess int
		fmt.Print("Your guess: ")
		_, err := fmt.Scanf("%d", &guess)

		if err != nil {
			fmt.Println("That doesn't look like a number. Try again.")
			continue
		}

		guessCount++

		if guess == number {
			fmt.Printf("You guessed my number in %d guesses!\n", guessCount)
			break
		} else if guess < number {
			fmt.Println("Too low. Try again.")
		} else {
			fmt.Println("Too high. Try again.")
		}
	}
}
