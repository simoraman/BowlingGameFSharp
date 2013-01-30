module BowlingGame.Tests

open NUnit.Framework
open FsUnit
open BowlingGameFSharp
let throwmany(amount, pins) = [ for n in 1..amount -> pins ]

[<TestFixture>] 
type BowlingGameTests()=   
    [<Test>]
    member x.``Bowling guttergame``() =
        let throws = throwmany(20, 0)
        score throws |> should equal 0
        
    [<Test>]
    member x.``Throw all ones``() =
        let throws = throwmany(20, 1) 
        score throws |> should equal 20

    [<Test>]
    member x.``Throw one spare``() =
        let sparethrows = [5; 5; 3]
        let manythrows=throwmany (17, 0)
        let throws = sparethrows @ manythrows
        score throws |> should equal 16

    [<Test>]
    member x.``Throw one strike``() =
        let throws = [10; 3; 4] @ throwmany (16, 0)
        score throws |> should equal 24

    [<Test>]
    member x.``Perfect game``() =
        let throws = throwmany (12, 10)
        score throws |> should equal 300

  