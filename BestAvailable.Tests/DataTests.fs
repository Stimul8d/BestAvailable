module DataTests

open Domain
open Xunit
open Swensen.Unquote
open Data

[<Fact>]
let ``Json parses correctly`` = 
    let expected = TestData.requests
    let actual = parseBookingsJson() 
    test <@ actual = expected @>

