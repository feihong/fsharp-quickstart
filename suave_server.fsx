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
let speciesTypesSorted =
  speciesTypes |> List.countBy id |> List.sortByDescending snd

for (type_, count) in speciesTypesSorted do
  printfn "%s -> %d" type_ count


(*
let html =
  [ yield "<html><body><table><thead><tr><th>Species</th></tr><tbody>"
    for (species, commonName, speciesType) do

    yield "</tbody></body></html>"
  ]
*)
