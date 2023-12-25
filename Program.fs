open System
open BPG.Generator

[<EntryPoint>]
let main (args : string[]) =
    let length =
        args[0]
        |> int
    
    if length < 1 then
        raise (new ArgumentOutOfRangeException("Length must be grater than 0"))
    
    length
    |> generate
    |> printfn "%s"

    0
