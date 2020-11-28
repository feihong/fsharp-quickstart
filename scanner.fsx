(*

https://craftinginterpreters.com/scanning.html

*)

type Token =
  // single character
  | LeftParen
  | RightParen
  | LeftBrace
  | RightBrace
  | Comma
  | Dot
  | Minus
  | Plus
  | Semicolon
  | Slash
  | Star
  // one or two characters
  | Bang
  | BangEqual
  | Equal
  | EqualEqual
  | Greater
  | GreaterEqual
  | Less
  | LessEqual
  // literals
  | Identifier of string
  | String of string
  | Number of float
  // keywords
  | And
  | Class
  | Else
  | False
  | Fun
  | For
  | If
  | Nil
  | Or
  | Print
  | Return
  | Super
  | This
  | True
  | Var
  | While
  // just for convenience
  | Eof

type State = {
  current: string
  next: string option
  rest: string
  tokens: Token list
  line: int
  errors: string list
}

let scanTokens text =
  [LeftParen; RightParen; LeftBrace; RightBrace;]

let run text =
  for token in scanTokens text do
    printfn "%A" token

run "( ) [ ]"
