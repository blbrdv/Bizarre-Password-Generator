module BPG.Generator
open Glyphs
open System
open System.Collections.Generic

let generate (length : int) =
    let shuffledArray =
        glyphs 
        |> Seq.sortBy (fun _ -> Guid.NewGuid())
        |> Queue

    let rec generateString (value : string) (length : int) =
        if value.Length > length then
            value
        elif value.Length = length then
            value[..length]
        else
            $"{value}{shuffledArray.Dequeue()}"
            |> generateString
            <| length
    
    generateString "" length
