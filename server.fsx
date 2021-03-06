(*

Before you try to run this script, you must first download the required packages:

  mono .paket/paket.exe install

*)
#r "packages/FSharp.Data/lib/net45/FSharp.Data.dll"
#r "packages/Suave/lib/net461/Suave.dll"

open FSharp.Data
open Suave

type Species = HtmlProvider<"https://en.wikipedia.org/wiki/The_world%27s_100_most_threatened_species">

let speciesTypes =
  [ for x in Species.GetSample().Tables.``Species list``.Rows -> x.Type ]
let stats =
  speciesTypes |> List.countBy id |> List.sortByDescending snd

let html =
  [ yield "<html><head><title>Threatened Animals</title>"
    yield "<style>
      table { border-collapse: collapse; }
      td, th { border: 1px solid gray; }
      </style></head>"
    yield "<body><table><thead><tr>"
    yield "<th>Category</th>"
    yield "<th>Number</th>"
    yield "</tr><tbody>"
    for (type_, count) in stats do
      yield sprintf "<tr><td>%s</td> <td>%d</td></tr>" type_ count
    yield "</tbody></table>"
    yield "</body></html>"
  ] |> String.concat "\n"

let config =
  { defaultConfig with
      bindings = [ HttpBinding.createSimple HTTP "127.0.0.1" 8000 ]
  }

let _ =
  startWebServer config (Successful.OK html)
