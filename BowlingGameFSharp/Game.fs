module BowlingGameFSharp
        
let calculate_strike_score (throws: int list) = 
    if throws.Length>3 then 10+throws.Item(1)+throws.Item(2)
    else 10

let rec score_throws (throws: int list) (score:int) =
        if throws.IsEmpty then (score)
        else
            if(throws.Head=10) then score_throws throws.Tail score+calculate_strike_score(throws) 
            elif(throws.Head+throws.Tail.Head=10) then score_throws throws.Tail.Tail (score+10+throws.Item(2))
            else score_throws throws.Tail.Tail score+throws.Head+throws.Tail.Head
        
type Game =
    new()={}
    member x.score throws =
        score_throws throws 0
        

        
