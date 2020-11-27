(*

Usage:

dotnet fsi create_process.fsx
dotnet fsi create_process.fsx packages

*)
#r "nuget: Fake.Core.Process"

open Fake.Core

// First argument is the name of the script itself
let path =
  match fsi.CommandLineArgs with
  | [|_; path|] -> path
  | _ -> "."

printfn "Listing the contents of '%s':\n" path

let result =
  CreateProcess.fromRawCommand "ls" ["-la"; path]
  |> CreateProcess.redirectOutput
  |> CreateProcess.ensureExitCode
  |> Proc.run

printfn "%s" result.Result.Output
