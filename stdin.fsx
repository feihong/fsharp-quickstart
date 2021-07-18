open System

let askForInput () =
    printf "> "
    Console.ReadLine()

let rec go () =
    match askForInput () with
    | s when s.Trim().ToLower() = "q" -> printfn "Quitting..."
    | s ->
        printfn "Upper: %s" (s.ToUpper())
        go ()

go ()
