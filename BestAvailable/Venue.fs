module Venue
open System.Diagnostics
open Domain

let buildVenue = 
    let buildSeat col row = 
        match (col, row) with
        | -1, _ -> Aisle
        | 3, "B" | 4, "B" -> Seat (Wheelchair {Row=row; Column=col})
        | 2, "B" | 5, "B" -> Seat (Companion {Row=row; Column=col})
        | _ -> Seat (Regular {Row=row; Column=col})

    let buildRow row = 
        match snd row with
        | 1 | 3 -> [1..3] @ [-1] @ [4..6] |> List.map (fun x -> buildSeat x (fst row))
        | 2 | 4 -> [6..-1..4] @ [-1] @ [3..-1..1] |> List.map (fun x -> buildSeat x (fst row))
        | _ -> failwith "There are no other rows!"

    Venue ([("A",1);("B",2);("C",3);("D",4);] 
    |> List.map (fun x -> buildRow x)  
    |> List.concat)

