//Adds all numbers in a list from 1 - n
[1..200] |> List.sum |> printfn "sum=%d"

//Square number n
let square x = x * x
let sq = square 42
printfn "square of x is %i" sq

//Function to add numers
let add x y = x + y
let twoplustwo = add 2 2
printfn "two plus two = %i" twoplustwo 