module SeatsAssignmentTests

open Xunit
open Swensen.Unquote
open Domain
open SeatAssignment

[<Fact>]
let ``Requests are seated correctly`` = 
    let venue = TestData.venue
    let requests = TestData.requests
    let expected = TestData.seatAssignments
    let actual = assignSeats
    ()