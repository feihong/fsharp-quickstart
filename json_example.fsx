#r "packages/FSharp.Data/lib/net45/FSharp.Data.dll"

open FSharp.Data

type Track = JsonProvider<"""
{
  "title": "TITLE",
  "artist": "ARTIST",
  "link": "https://example.com/hello/",
  "genre": "GENRE",
  "lyrics": "LYRICS",
  "location": "/Users/bob/tracks/hello.m4a"
}
""">

let track = Track.Parse("""
{
  "title": "流光似水",
  "artist": "梦离子 ᴍ∞ɴʀɪᴢᴇ",
  "link": "https://youtu.be/Ah5nnELYfXQ",
  "genre": "电子 Electronica",
  "lyrics": "作词：李映霏\n作曲：李映霏\n编曲：李映霏\n混音：Xico\n===\n\n轻轻地我们睁开眼睛\n慢慢地波光水面透明\n静静地水底呼吸\n偷偷地 偷偷悄悄 清醒\n好好地 好好呼吸光影\n\n我们的脚跟扬起\n流光中一起换气\n慢慢就在这里好\n慢慢就在这里\n轻地\n轻地\n\n\n当世界被探索完毕、海洋陆地都被命名\n我宽阔的宇宙心灵 还有许多未知在等着你\n\n我的心仍可以以你命名陆地、包容存放着你\n\n肌肤上的痣是繁星\n是星图它引领着你 航向我的宇宙心灵\n我的陆地等你命名\n\n我的心灵、我的身体\n与你一起呼吸\n剥落尘俗忧郁",
  "location": "/Users/bob/tracks/2020-04/夢離子 ᴍ∞ɴʀɪᴢᴇ  流光似水.m4a"
}
""")

printfn "%s by %s (%s)" track.Title track.Artist track.Genre
