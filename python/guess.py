import random
import sys

min = 1
max = 1000

if len(sys.argv) > 1 :
    max = int(sys.argv[1])

number = random.randint(min, max)

print('I have selected a number between %d and %d' % (min, max))
print('Please try to guess my number.')

guess_count = 0

while True : 
    guess = input('Your guess: ')

    try :
        guess = int(guess)
    except :
        print("That doesn't look like a number. Try again.")
        continue

    guess_count += 1

    if guess == number :
        print('You guess by number in %d guesses!' % (guess_count))
        break
    elif guess > number : 
        print('Your guess was too high. Try again.')
    else :
        print('Your guess was too low. Try again.')
