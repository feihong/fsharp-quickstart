(*

  Usage:

  dotnet fsi zip_write.fsx temp.html temp.json README.md

*)
#r "nuget: Fake.IO.Zip"

open Fake.IO

// First argument is the name of the script itself
let files =
  match fsi.CommandLineArgs with
  | args when args.Length > 1 -> args.[1..]
  | _ -> [|"README.md"|]

printfn "Zipping up these files: %s\n" (files |> String.concat ", ")

Zip.createZip "." "temp.zip" "ignored comment" 0 true files
printfn "Generated temp.zip"
