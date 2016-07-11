(*

To run this script:

  fsharpi hello.fsx

*)

let _ =
  [ for i in 1..5 -> printfn "Hello World %d" i ]
