(*

To compile this program:

  fsharpc -o hello.exe hello.fs

To run hello.exe:

  mono hello.exe

*)
open System

let rand = System.Random()

let getRandomHanzi () =
  rand.Next(0x4e00, 0x9fff + 1)
  |> Convert.ToChar
  |> Convert.ToString

let _ =
  printfn "你好世界！\nHere are some random characters:"

  for i = 1 to 10 do
    printfn "%s" (getRandomHanzi ())
