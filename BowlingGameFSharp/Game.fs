namespace BowlingGameFSharp
// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

type Game =
    new()={}
    member x.throw pins =
        pins
    member x.score throws =
        List.fold (fun acc x -> acc+x) 0 throws
