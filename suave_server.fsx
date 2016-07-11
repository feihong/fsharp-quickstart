(*

Before you try to run this script, you must first download the required packages:

  paket install

*)
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"
#r "packages/Suave/lib/net40/Suave.dll"

open FSharp.Data
open Suave

type Species = HtmlProvider<"https://en.wikipedia.org/wiki/The_world%27s_100_most_threatened_species">

let speciesTypes =
  [ for x in Species.GetSample().Tables.``Species list``.Rows -> x.Type ]
let stats =
  speciesTypes |> List.countBy id |> List.sortByDescending snd

//for (type_, count) in stats do
//  printfn "%s -> %d" type_ count


let html =
  [ yield "<html><head><title>Threatened Animals</title></head>"
    yield "<body><ul>"
    for (type_, count) in stats do
      yield sprintf "<li>%s -> %d</li>" type_ count
    yield "</ul></body></html>"
  ] |> String.concat "\n"

printfn "%s" html
