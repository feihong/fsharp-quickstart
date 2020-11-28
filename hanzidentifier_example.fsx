#load "Hanzidentifier.fsx"
open Hanzidentifier

let texts = [
  "闎跴倊円唦變秒鞝"
  "你喜欢阅读小说吗？"
  "我非常喜歡閱讀小說！"
  "你喜歡 看金庸的小说吗？"
  "她看上你了，你要小心哦"
  "There's no Chinese here"
]

for text in texts do
  printfn "%s -> %A" text (Hanzidentifier.identify text)
