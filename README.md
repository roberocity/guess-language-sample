# A Quick Review of some Programming Languages

## The Test Application: Guess a Number

This is a quick set of sample applications to allow a user to guess a random number. The flow of the application is this:

1. computer selects a random number between 1 and some maximum
2. computer asks the user to guess a number
3. if the guess is the selected random number, tell the user "you guessed my number in # guesses"
4. if the guess is lower than the selected number, tell the user "too low" and allow another guess
5. if the guess is higher than the selected number, tell the user "too high" and allow another guess

## Language Choices

This simple application will be implement in various programming languages in an effort to see the similarities and the differences between the languages. 

- [C#](#cs) - this is the language that I use the most
- [C](#c) - a low-level language with similar syntax to C Sharp
- [F#](#fs) - a functional language for .NET. 
- [Python](#py) - a scripting language 
- [Javascript](#js) - a web focused language that runs in web-browsers and on the server. This will be a node.js console application.
- [Go](#go) - a low-level, newish language that I want to know better
- [Rust](#rs) - a language that, as of now, I know very little about
- [Haskell](#hs) - an old functional language that I would like to explore

In each of the languages I have tried to use the conventions and practices of that language as well as follow good software design patterns. I'm not an expert in any of these languages. My hope is that by implementing this same, trivial application in each language I'll learn the idioms and syntax of that language.

### C#

I use C# on a daily basis in my work life. I've used it since it was released in 2001 so I've faily used to writing code there. It is my go to language when I want to just get something done. However, that is slowly changing and I branch out into other languages. 

C# tends to have a lot of boiler-plate code just to get things setup and going. That's changing a bit with C# version 9, but I haven't ventured there just yet. It is frustrating to have to have a class and static `main` method just to do a simple application like this.

The C# version was the first version that I implemented. Writing the application didn't take but a few minutes and I had something running. I don't think there's anything there to optimize. I think the code is fairly readable and makes sense for a typical C# developer. 

### Python

I'm no Python expert, but I didn't struggle to write this application. Python is about as straight forward as a language can be when it comes to simple script-like code like this. I've only used Python for simple scripts. While I have used Python classes previously, I didn't see the benefit here. I'm also not sure I could do Python classes without having to pull up documentation. For this simple script I was able to do everything with existing knowledge.

I was able to bang out the code for this very quickly. Ran through a few scenarios to make sure it was working properly. 

I enjoy Python and for scripts like this, it works really well. 

### Go

I've used Go only a little, but I've enjoyed it every time I've used it. I know there are some patterns, etc. that can be used to simplify the error checking, but I just chose to keep that all inline here. 

I really like the pattern of a function returning a `value(s), error` and checking for the `error` before using the `value(s)`. In fact, I have implemented similar patterns in a lot of the C# code that I write currently.

One of my favorite features of Go is that it is opinionated on code style and variable usage. If you define a variable and don't use it Go won't even compile the code. 

### JavaScript

I use JavaScript in the browser very often. I write a lot of vanilla js as well as use Vue and React. Until this project I had never written any js that was meant to run only on the console. I do like the js event loop, but it bit me in this experiment. I used the `readline` library (because that was the first one I found in a Google search for reading input). In my original loop, the console kept asking for input, but never accepting it. This was because my loop was a simple for loop that ignored the event loop. 

I didn't really enjoy JavaScript for this type of work. The console doesn't seem to need the event loop, but I'm sure I'm missing something and it could be useful. 

### C

I took one programming class at university. That was back in the late 90s. That class was a C class. It is probably the only class where I aced every assignment and exam. Why I didn't take that as a sign of what to do as a career I'm not sure, but I really do love the path I've taken so everything's good. 

C# and C share so much syntax that this wasn't too challenging for me. It came down to knowing the libraries and functions to use to capture input from the user and generate a random number. 

The biggest gotcha was around the `scanf` call to capture the input from the user. If a bad value was passed in (e.g. `hello` instead of a valid number) the console was get stuck in a loop. It wasn't automatically clearing the input so the `scanf` continued to read the existing input. I snagged the `while` loop from a Google search. I understand what it is doing, but find it frustrating that I have to do it. 

### Rust

This was my very first venture into the Rust language. Overall, I liked the experience a lot. The language has some nice features, but none of it was intuative. I had to read up a bit on the syntax and structure of the code. And it did help that the documentation had almost this exact application as an example program. 

I like the `match ... {}` syntax. It wasn't intuative and I'm sure that I can't repeat the functionality without doing more research. I really like the shadowing functionality of a variable. I like that I can name an earlier variable `guess` as a `string` and then redefine it later as an `int`. It keeps the strong typing, but feels more like a scripting language with loose typing. 

While I don't think there's a lot of boiler plate code, using Cargo was a bit of curve. 

Rust shows a warning when compiling code that has defined a varialbe, but not used that variable. This is a step back from Go, but still a good practice in my opinion.

### F# 

I like the what I think I understand about the functional paradigm a lot. I'm sure that my implementation here isn't the best. This, like Rust, was my first real venture into F#. I've toyed around with it, read, and talked about it, but never used it to actually make anything of consequence. In fact I think this was the first time I wrote F# code not in F# Interactive mode. 

I like recursion, but it feels a bit of a forced-fit implemented this way. There is a base case of an accurate guess and then recurse over too high or too low. I would have preferred to pattern match around the guess and expected number instead of the `if...else` block. I'm sure there's a way to do that, but I just couldn't see it. I tried a few things, but nothing seemed to work exactly as I expected. I need more time to play with the language I think.

F# has a bit too much boiler plate as well because of the .NET framework. While I did create a full `.fsproj` using the `dotnet new ...` command I _think_ it would be possible to write and compile this using just one `.fs` file.

### Haskell

Ok. So I've read about Haskell, watched some masters write Haskel code, and even have some (yet unread) books about Haskell, but this was the first time I ever tried to write anything in Haskell that was just a simple `sum` or `count` a `list` function. 

I can't say that I loved the experience. I had to Google more when working on this solution than on any of the others combined. I think it was because I don't know Haskell's syntax at all and the compiler doesn't always give helpful errors. In my experience the error the compiler complained about was the actual error in the code. It took some trial and error to figure that out. 

I had to grasp a bit about the `stack` paradigm as well as the language syntax. The `import System.Random` was much harder than it had to be I think. 

The solution here is very similar in pattern to the F# solution that I created first, but with a few changes to make sure that all of the `if...else` statements returned the exact same type. 

I don't love how I kept track of the number of guesses made in either this or the F# solution, but it works. 

I like the fact that I can use `_` to tell Haskell that I may require something, but I don't care about it. This feature is in F# too and is moving into C# as well. 



