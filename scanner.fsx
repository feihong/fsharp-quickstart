(*

https://craftinginterpreters.com/scanning.html

*)

type Token =
  | Comma
  | Semicolon

type State =
  { Current: string;
    Next: string option;
    Rest: string;
    Tokens: Token list;
    Line: int;
  }

let _ =
  printfn "hey"
