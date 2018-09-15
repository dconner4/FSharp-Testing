open System

let FtoC (x: int) = ((x - 32) * 5/9)
let CtoF x = (x * 5/9) + 32
let getCFromF = FtoC 74
printfn "F to C is %i" getCFromF

let getTempScale = 
    let tempStd = printf "Input the standard [F]arenheit or [C]elcius "
    Console.ReadLine()

let getCurrTemp = 
    Console.Write("Input the current temp ")
    let (currTemp: int) = int32(Console.ReadLine())
    match getTempScale with
    | "F" -> FtoC currTemp
    | "C" -> CtoF currTemp
    | _ -> 0

let output = getCurrTemp
printfn "Output temp is %i" output


