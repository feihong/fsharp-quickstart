#r "nuget: Fake.Core.Process"

open Fake.Core

let result =
  CreateProcess.fromRawCommand "ls" ["-la"; "packages"]
  |> CreateProcess.redirectOutput
  |> CreateProcess.ensureExitCode
  |> Proc.run

printfn "%s" result.Result.Output
