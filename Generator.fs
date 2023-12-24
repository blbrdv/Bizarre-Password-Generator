module BPG.Generator
open System

let generate (pack : string list) (length : int) : string =
    let rec generateString (value : string) (length : int) =
        if value.Length > length then
            value
        elif value.Length = length then
            value[..length]
        else
            let shuffledArray =
                pack 
                |> List.sortBy (fun _ -> Guid.NewGuid())
                
            $"{value}{shuffledArray[0]}"
            |> generateString
            <| length
    
    generateString "" length
