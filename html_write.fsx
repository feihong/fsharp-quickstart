#r "nuget: FSharp.Data"
#r "nuget: Giraffe.ViewEngine"

open System.IO
open FSharp.Data
open Giraffe.ViewEngine

type Tracks = JsonProvider<"""
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
    "genre": "摇滚/说唱",
    "link": "https://www.youtube.com/watch?v=HlWoGe7zQZs"
  }
]
""">

// for track in Tracks.GetSamples() do
//   printfn "%s by %s (%s)" track.Title track.Artist track.Genre

let page =
  html [] [
    head [] [
      meta [ _charset "utf-8" ]
    ]
    body [] [
      h1 [] [ str "你好世界！" ]
    ]
  ]

// printfn "%s" (RenderView.AsString.htmlDocument page)

let output = RenderView.AsString.htmlDocument page
File.WriteAllText("temp.html", output)
printfn "Generated temp.html"
