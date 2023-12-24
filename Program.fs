open Argu
open BPG.Generator
open BPG.Arguments
open BPG.Glyphs

[<EntryPoint>]
let main (argsRaw : string[]) =
    let parser = ArgumentParser.Create<CliArguments>(programName = "bpg.exe",
                                                    checkStructure = false)
    let args = parser.ParseCommandLine(raiseOnUsage = true)
    let mutable pack = []
    
    if args.Contains SpecialSymbols then
        pack <- glyphs
    else
        pack <- glyphs @ glyphsSpecial
    
    args.GetResult Length
    |> generate pack
    |> printfn "%s"

    0
