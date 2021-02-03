import System.Random


selectNumberInRange x y = getStdRandom (randomR (x,y))

guessedIt _ attempts = do
    print ("You guessed my number in " ++ show attempts ++ " guesses.")


checkGuess expected actual attempts = do

    -- // start-snippet: hs-if-else
    if expected == actual then do
        guessedIt expected attempts

    else if expected > actual then do
        print "Too low. Try again."
        guessIt expected attempts

    else do
        print "Too high. Try again."
        guessIt expected attempts
    -- // end-snippet


guessIt num attempts = do
    print "Your guess: "
    gs <- getLine 
    let g = (read gs :: Int)
    let a = attempts + 1

    checkGuess num g a


main = do
    let min = 1
    let max = 1000

    number <- selectNumberInRange min max

    print ("I have selected a number between " ++ show min ++ " and " ++ show max ++ ".")
    print ("Don't tell anyone, but my number is " ++ show number)
    print "Please guess my number."
    
    guessIt number 0

  
    