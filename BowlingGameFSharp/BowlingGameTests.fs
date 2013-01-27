module BowlingGame.Tests

open NUnit.Framework
open FsUnit
open BowlingGameFSharp
let throwmany(amount, pins) = [ for n in 1..amount -> pins ]

[<TestFixture>] 
type BowlingGameTests()=   
    [<Test>]
    member x.``Bowling guttergame``() =
        let game=new Game()
        let throws = throwmany(20, 0)
        game.score throws |> should equal 0

    [<Test>]
    member x.``Throw all ones``() =
        let game=new Game()
        let throws = throwmany(20, 1) 
        game.score throws |> should equal 20

    [<Test>]
    member x.``Throw one spare``() =
        let game=new Game()
        let sparethrows = [5; 5; 3]
        let manythrows=throwmany (17, 0)
        let throws = sparethrows @ manythrows
        game.score throws |> should equal 16

    [<Test>]
    member x.``Throw one strike``() =
        let game=new Game()
        let throws = [10; 3; 4] @ throwmany (16, 0)
        game.score throws |> should equal 24

    [<Test>]
    member x.``Perfect game``() =
        let game=new Game()
        let throws = throwmany (12, 10)
        game.score throws |> should equal 300

  