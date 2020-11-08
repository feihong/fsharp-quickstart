﻿open System
open System.Drawing
open Colorful   // third party library

let rand = System.Random()

let getRandomHanzi () =
  rand.Next(0x4e00, 0x9fff + 1)
  |> Convert.ToChar
  |> Convert.ToString

[<EntryPoint>]
let main argv =
  Console.WriteLine("你好世界！\n", Color.Green);
  printfn "Here are some random characters:"

  for i = 1 to 10 do
    printfn "%s" (getRandomHanzi ())

  0 // return an integer exit code
