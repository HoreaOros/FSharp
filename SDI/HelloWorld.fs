module HelloWorld
open System

let cube x = x * x * x

[<EntryPoint>]
let main (args : string[]) =
    if args.Length <> 2 then
        failwith "Error: Expected arguments <greeting> and <thing>"
    let greeting, thing = args.[0], args.[1]
    let timeOfDay = System.DateTime.Now.ToString("hh:mm tt")
    printfn "%s, %s at %s" greeting thing timeOfDay


    let x = 1 // se creeza valoarea x de tip int
    let y = 2.3 // se creeaza valoarea y de tip float
    printfn "%f" (float x + y) // pentru a putea aduna cele doua valori de tip diferit, x trebuie convertit in float

    printfn "%d" (cube 4)
    // Program exit code
    0

