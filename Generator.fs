module BPG.Generator
open System
open BPG.Chords

let generate (length : int) : string =
    let rec generateString (value : string) (length : int) =
        if value.Length > length then
            value
        elif value.Length = length then
            value[..length]
        else
            let shuffledArray =
                chords 
                |> List.sortBy (fun _ -> Guid.NewGuid())
                
            $"{value}{shuffledArray[0]}"
            |> generateString
            <| length
    
    generateString "" length
