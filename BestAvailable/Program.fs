open System
open Data
open Venue
open SeatAssignment

[<EntryPoint>]
let main argv = 
    let bookings = parseBookingsJson
    let venue = buildVenue
    let result = assignSeats bookings venue
    Console.ReadKey() |> ignore
    0 // return an integer exit code
