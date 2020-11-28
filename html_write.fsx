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

let cellStyle = _style "padding: 0.5rem; border: 1px solid gray;"

let page =
  html [] [
    head [] [
      meta [ _charset "utf-8" ]
    ]
    body [] [
      h1 [] [ str "歌曲" ]
      table [ _style "border-collapse: collapse" ] [
        thead [] [
          tr [] [
            th [ cellStyle ] [ str "名字" ]
            th [ cellStyle ] [ str "歌手" ]
            th [ cellStyle ] [ str "风格" ]
          ]
        ]
        tbody [] [
          for track in Tracks.GetSamples() ->
            tr [] [
              td [ cellStyle ] [
                a [ _href track.Link; _target "_blank" ] [
                  str track.Title
                ]
              ]
              td [ cellStyle ] [ str track.Artist ]
              td [ cellStyle ] [ str track.Genre ]
            ]
        ]
      ]
    ]
  ]

let output = RenderView.AsString.htmlDocument page
File.WriteAllText("temp.html", output)
printfn "Generated temp.html"
