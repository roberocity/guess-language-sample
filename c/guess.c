#include <stdio.h>
#include <sys/random.h>

int randnum(int max) {
    int val;

    // useful only on linux systems...
    getrandom(&val, sizeof(int), GRND_NONBLOCK);

    if (val < 0) {
        return -1 * val % max + 1;
    } else {
        return val % max + 1;
    }
}

int main(void) {
    int max = 1000;
    int number = randnum(max);
    int guessCount = 0;
    int guess;

    printf("I have selected a number between %d and %d.\n", 1, max);
    printf("Please guess my number.\n");

    while (1) {
        printf("Your guess: ");

        if ( scanf("%d", &guess) != 1 ) {
            int c;
            while ((c = getchar()) != EOF && c != '\n')
            {
                continue;
            }
            printf("That doesn't look like a valid number. Try again.\n");
            continue;
        }

        guessCount ++;

        if ( guess == number ) {
            printf("You guessed my number in %d guesses.\n", guessCount);
            break;
        } else if (guess > number) {
            printf("Too high. Try again.\n");
        } else {
            printf("Too low. Try again.\n");
        }
    }
}