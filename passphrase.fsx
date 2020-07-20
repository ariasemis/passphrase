#r @"packages/FSharp.Data/lib/netstandard2.0/FSharp.Data.dll"

open System
open FSharp.Data

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

let csv = new CsvProvider<"wordlist.csv", HasHeaders = false>()

let find n =
    csv.Rows |> Seq.find (fun r -> r.Column1 = n)

let word n = (find n).Column2

let rnd = new Random()

let dice() = rnd.Next(1, 7)

let num digits = 
    digits |> List.fold (fun acc n -> acc * 10 + n) 0

let roll() = 
    [1..5] |> List.map (fun _ -> dice()) |> num

let passphrase =
    [1..6] |> List.map (fun _ -> roll()) |> List.map word |> String.concat " "

printfn "your passphrase is:"
printfn "%s%s" Environment.NewLine passphrase