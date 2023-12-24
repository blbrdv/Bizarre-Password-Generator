module BPG.Arguments
open Argu

type CliArguments =
    | [<MainCommand; ExactlyOnce; First>] Length of int
    | [<AltCommandLine("-s"); Unique>] SpecialSymbols

    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | Length _ -> "specify a password length."
            | SpecialSymbols _ -> "specify either use or not glyphs with special symbols."
