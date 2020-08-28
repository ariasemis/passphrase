open System

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

let words =
    IO.File.ReadAllLines("eff_large_wordlist.csv")
    |> Seq.map (fun r -> r.Split(','))
    |> Seq.map (fun r -> int r.[0], r.[1])
    |> Map.ofSeq

let rnd = new Random()

let dice() = rnd.Next(1, 7)

let num digits = 
    digits |> List.fold (fun a n -> a * 10 + n) 0

let roll() = 
    [1..5] |> List.map (fun _ -> dice()) |> num

let passphrase =
    [1..6]
    |> List.map (fun _ -> roll())
    |> List.map (fun n -> words.[n])
    |> String.concat " "

printfn "%s" passphrase