open System
open System.Drawing
open Colorful   // third party library

let getRandomHanzi =
  let rand = System.Random()
  fun () ->
    rand.Next(0x4e00, 0x9fff + 1)
    |> Convert.ToChar
    |> Convert.ToString

let makeListBy n fn =
  let generator = fun i ->
    if i = n then None
    else Some (fn i, i+1)
  List.unfold generator 0

[<EntryPoint>]
let main argv =
  Console.WriteLine("你好世界！\n", Color.Green);
  printfn "Here are some random characters:"

  let hanziList = makeListBy 12 (fun _ -> getRandomHanzi ())
  Console.WriteLine(hanziList |> String.concat ", ", Color.Yellow)

//   for i = 1 to 10 do
//     printfn "%s" (getRandomHanzi ())

  0 // return an integer exit code
