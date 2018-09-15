let ReverseString (s:string) = new string(Array.rev (s.ToCharArray()))

let inputStr:string = Console.ReadLine()
let outputStr = ReverseString inputStr
printfn "The reversed string is %s" outputStr