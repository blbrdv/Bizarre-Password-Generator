open BPG.Generator

[<EntryPoint>]
let main (args : string[]) =
    args[0]
    |> int
    |> generate
    |> printf "%s"

    0
