module Domain

open System.Diagnostics
open FSharp.Data

type Json = JsonProvider<"Data.json">

type SeatRequest = {NumberOfSeats:int; Type:string}

type Request = {Id:int; Seats:SeatRequest list}

type Requests = Requests of Request list

[<DebuggerDisplay("{Row}:{Column}")>]
type Position = {Row:string; Column:int}

type Seat = 
    | Regular of Position
    | Wheelchair of Position
    | Companion of Position

type Space = 
    | Seat of Seat
    | Aisle 

type Venue = Venue of Space list

type RequestConfirmation = {RequestId:int; Type:string; Position:Position}

type SeatAssignment = 
    | NotSeated of Position
    | Seated of RequestConfirmation

type AssignedSeats = AssignedSeats of SeatAssignment list


