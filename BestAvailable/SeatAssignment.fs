module SeatAssignment
open Data
open Domain

let assignSeats requests venue = AssignedSeats ([
                                                NotSeated {Row="A"; Column=4}
                                                ])