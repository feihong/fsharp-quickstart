#load "HanziConv.fsx"
open HanziConv

let tradTexts = [
  "你喜歡閱讀小說嗎？"
  "我非常喜歡閱讀小說！"
]

for text in tradTexts do
  printfn "%s -> %s" text (HanziConv.toSimplified text)

printfn ""

let simpTexts = [
  "你喜欢阅读小说吗？"
  "我非常喜欢阅读小说！"
]

for text in simpTexts do
  printfn "%s -> %s" text (HanziConv.toTraditional text)
