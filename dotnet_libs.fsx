(*

How to use .NET libraries.

*)
open System.IO
open System.Net

let http (url: string) =
  let req = WebRequest.Create(url)
  let resp = req.GetResponse()
  let stream = resp.GetResponseStream()
  let reader = new StreamReader(stream)
  let html = reader.ReadToEnd()
  resp.Close()
  html

let _ = printfn "%s" <| http "http://ipecho.net/plain"
