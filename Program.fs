open System
open System.Drawing
open Colorful   // third party library

let getRandomHanzi =
  let rand = System.Random()
  fun () ->
    rand.Next(0x4e00, 0x9fff + 1)
    |> Convert.ToChar
    |> Convert.ToString

let makeListUsingGenerator n fn =
  let generator = fun i ->
    if i = n then None
    else Some (fn i, i + 1)

  List.unfold generator 0

let parseInt s =
  try
    Some (int s)
  with
  | :? System.FormatException -> None

[<EntryPoint>]
let main argv =
  Console.WriteLine("你好世界！\n", Color.Green);

  let count =
    match argv with
    | [|n|] -> parseInt n |> Option.defaultValue 8
    | _ -> 8

  printfn "Generate %d random characters:" count

  Console.WriteLine(seq {for _i in 1 .. count -> getRandomHanzi ()} |> String.concat ", ", Color.Cyan)

  let hanziList = makeListUsingGenerator count (fun _ -> getRandomHanzi ())
  Console.WriteLine(hanziList |> String.concat ", ", Color.Yellow)

  0 // optionally return an integer exit code
