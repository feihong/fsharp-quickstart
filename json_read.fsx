// #r "packages/FSharp.Data/lib/net45/FSharp.Data.dll" // needed if not on .NET 5, also noticeably faster
#r "nuget: FSharp.Data"

open System.IO
open FSharp.Data

type Tracks = JsonProvider<"""
[
  {
    "title": "TITLE",
    "artist": "ARTIST",
    "genre": "GENRE",
    "link": "https://example.com/hello/"
  }
]
""">

let tracks =
  File.ReadAllText("./tracks.json")
  |> Tracks.Parse

for track in tracks do
  let genre =
    match track.Genre with
    | "" -> "N/A"
    | genre -> genre
  printfn "%s by %s (%s)" track.Title track.Artist genre
