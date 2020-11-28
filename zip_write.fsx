(*

  Usage:

  dotnet fsi zip_write.fsx temp.html temp.json README.md
  unzip -l temp.zip

*)
#r "nuget: Fake.IO.Zip"
#r "nuget: Fake.IO.FileSystem"

open Fake.IO
open Fake.IO.Globbing.Operators

// First argument is the name of the script itself
let files: string seq =
  match fsi.CommandLineArgs with
  | args when args.Length > 1 -> args.[1..] |> Array.toSeq
  | _ -> !! "./*.fsx" |> Seq.cast<string>

printfn "Zipping up these files:\n"
for file in files do
  printfn "%s" file

Zip.createZip
  "."         // working directory
  "temp.zip"  // zip file name
  ""          // ignored comment
  0           // compression level
  true        // all files are put at root level
  files       // sequence of file paths

printfn "\nGenerated temp.zip"
