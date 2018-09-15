open System

let hello() = 
    printf "Print your name: "

    let name = Console.ReadLine()

    printfn "Hello %s" name

hello()
Console.ReadKey() |> ignore