module BowlingGameFSharp.Tests

open NUnit.Framework
open FsUnit

let throwmany(game:Game, amount, pins) = [ for n in 1..amount -> game.throw(pins) ]

[<TestFixture>] 
type BowlingGameTests()=   
    [<Test>]
    member x.``Bowling guttergame``() =
        let game=new Game()
        let throws = throwmany(game, 20, 0)
        game.score throws |> should equal 0

    [<Test>]
    member x.``Throw all ones``() =
        let game=new Game()
        let throws = throwmany(game, 20, 1) 
        game.score throws |> should equal 20

    [<Test>]
    member x.``Throw one spare``() =
        let game=new Game()
        let sparethrows = [game.throw 5; game.throw 5; game.throw 3]
        let manythrows=throwmany (game, 17, 0)
        let throws = sparethrows @ manythrows
        game.score throws |> should equal 16




  