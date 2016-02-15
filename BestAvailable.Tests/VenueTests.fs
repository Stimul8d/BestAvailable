module VenueTests

open Xunit
open Venue
open Swensen.Unquote
open Domain 

[<Fact>]
let ``Venue is created correctly using snaking method`` = 
    let expected = TestData.venue
    let actual = buildVenue
    test <@ actual = expected @>