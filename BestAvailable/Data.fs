module Data

open FSharp.Data
open Domain

let parseBookingsJson () = 
    let data = Json.GetSample()
    Requests (data.Requests |> Array.map (fun r-> {Id=r.Id; Seats= r.Seats 
                            |> Array.map (fun s -> {NumberOfSeats=s.Seat; Type=s.Type}) |> Array.toList}) 
                            |> Array.toList)
