(*

Before you try to run this script, you must first download the required packages:

  paket install

*)
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"

open FSharp.Data

type Species = HtmlProvider<"https://en.wikipedia.org/wiki/The_world%27s_100_most_threatened_species">

let species =
  [ for x in Species.GetSample().Tables.``Species list``.Rows ->
    x.Species, x.``Common name``, x.Type ]
for (species, name, type_) in species do
    printfn "%s, %s (%s)" species name type_
