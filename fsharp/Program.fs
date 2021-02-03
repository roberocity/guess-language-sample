// Learn more about F# at http://fsharp.org

open System

let rnd = System.Random()   

let makeGuess count expected =
    printf "Your guess: "
    let guess = System.Console.ReadLine() |> int
    (expected, guess, (count + 1))


let rec checkGuess guess =
    let expected, actual, count = guess

    if expected = actual then
        printfn "You guessed my number in %d guesses" count

    else if expected > actual then
        printfn "Too low. Try again"
        checkGuess (makeGuess count expected)

    else 
        printfn "Too high. Try again"
        checkGuess (makeGuess count expected)


[<EntryPoint>]
let main argv =
    let min = 1
    let max = match argv with
              | [|v|] -> v |> int
              | _ -> 1000
    
    printfn "I've select a number between %d and %d." min max
    printfn "Please try to guess my number."

    checkGuess (makeGuess 0 (rnd.Next (min, max)))

    0 // return an integer exit code

