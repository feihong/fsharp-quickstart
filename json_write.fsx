#r "nuget: FSharp.Json"

open System.IO
open FSharp.Json

type Track = {
  title: string
  artist: string
  genre: string
  link: string option
}

let tracks: Track list = [
  {
    title = "流光似水";
    artist = "梦离子 ᴍ∞ɴʀɪᴢᴇ";
    genre = "电子 Electronica";
    link = Some "https://youtu.be/Ah5nnELYfXQ";
  }
  {
    title = "扯谎哥";
    artist = "阿朵";
    genre = "世界音乐 World";
    link = None;
  }
]

let config = JsonConfig.create(serializeNone = SerializeNone.Omit)
let json = Json.serializeEx config tracks
printfn "%s\n" json
printfn "Wrote output to temp.json"
File.WriteAllText("temp.json", json)
