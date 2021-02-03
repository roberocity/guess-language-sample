use std::io;
use std::cmp::Ordering;
use rand::Rng;

fn main() {
    let min = 1;
    let max = 1000;

    let number = rand::thread_rng().gen_range(min, max);

    println!("I have selected a number between {} and {}.", min, max);
    println!("Please try to guess my number.");

    let mut guess_count = 0;

    loop {
        println!("Your guess: ");

        let mut guess = String::new();
        
        io::stdin()
            .read_line(&mut guess)
            .expect("Failed to read input.");

        let guess: u32 = match guess
            .trim()
            .parse() {
                Ok(num) => num,
                Err(_) => {
                    println!("That doesn't look like a number.");
                    continue;
                },
            };
        
        guess_count += 1;

        match guess.cmp(&number) {
            Ordering::Less => println!("Too low. Try again."),
            Ordering::Greater => println!("Too high. Try again."),
            Ordering::Equal => {
                println!("You guessed my number in {} guesses.", guess_count);
                break;
            },
        }
    }
}