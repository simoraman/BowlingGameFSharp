module BowlingGameFSharp
        
let private calculate_strike_score (throws: int list) = 
    if throws.Length>3 then 10+throws.Item(1)+throws.Item(2)
    else 10

let private calculate_spare_score (throws:int list) = 10+throws.Item(2)

let rec private score_throws (throws: int list) (score:int) =
    match throws with
    | [] -> score
    | throws when throws.Head = 10 
        -> score_throws throws.Tail (score + calculate_strike_score(throws)) 
    | throws when (throws.Head + throws.Tail.Head = 10) 
        -> score_throws throws.Tail.Tail (score + calculate_spare_score(throws))
    | _ -> score_throws throws.Tail.Tail (score + throws.Head+throws.Item(1))

let score throws = score_throws throws 0
        