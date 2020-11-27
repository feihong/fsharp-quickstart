// #r "nuget: FSharp.Data" // works on .NET 5, but is noticeably slower
#r "packages/FSharp.Data/lib/net45/FSharp.Data.dll"

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

let tracks = Tracks.Parse("""
[
  {
    "title": "流光似水",
    "artist": "梦离子 ᴍ∞ɴʀɪᴢᴇ",
    "link": "https://youtu.be/Ah5nnELYfXQ",
    "genre": "电子 Electronica"
  },
  {
    "title": "扯谎哥",
    "artist": "阿朵",
    "link": "https://youtu.be/oSrU-b58ovg",
    "genre": "世界音乐 World"
  },
  {
    "title": "昆仑山牧人",
    "artist": "Haya乐团xYamy郭颖",
    "link": "https://www.youtube.com/watch?v=HlWoGe7zQZs"
  }
]
""")

for track in tracks do
  let genre =
    match track.Genre with
    | "" -> "N/A"
    | genre -> genre
  printfn "%s by %s (%s)" track.Title track.Artist genre
