module TestData
open Domain

let venue = Venue ([
                    Seat(Regular{Row="A"; Column=1});Seat(Regular{Row="A"; Column=2});Seat(Regular{Row="A"; Column=3});
                    Aisle;
                    Seat(Regular{Row="A"; Column=4});Seat(Regular{Row="A"; Column=5});Seat(Regular{Row="A"; Column=6});
                    Seat(Regular{Row="B"; Column=6});Seat(Companion{Row="B"; Column=5});Seat(Wheelchair{Row="B"; Column=4});
                    Aisle;
                    Seat(Wheelchair{Row="B"; Column=3});Seat(Companion{Row="B"; Column=2});Seat(Regular{Row="B"; Column=1});
                    Seat(Regular{Row="C"; Column=1});Seat(Regular{Row="C"; Column=2});Seat(Regular{Row="C"; Column=3});
                    Aisle;
                    Seat(Regular{Row="C"; Column=4});Seat(Regular{Row="C"; Column=5});Seat(Regular{Row="C"; Column=6});
                    Seat(Regular{Row="D"; Column=6});Seat(Regular{Row="D"; Column=5});Seat(Regular{Row="D"; Column=4});
                    Aisle;
                    Seat(Regular{Row="D"; Column=3});Seat(Regular{Row="D"; Column=2});Seat(Regular{Row="D"; Column=1});
                    ])

let requests = Requests([
                        {Id=1; Seats=[{NumberOfSeats=1;Type="wheelchair"};{NumberOfSeats=1;Type="companion"}]};
                        {Id=2; Seats=[{NumberOfSeats=2;Type="adult"};{NumberOfSeats=1;Type="child"}]};
                        {Id=3; Seats=[{NumberOfSeats=6;Type="adult"}]};
                        {Id=4; Seats=[{NumberOfSeats=7;Type="child"};{NumberOfSeats=1;Type="adult"}]};
                        {Id=5; Seats=[{NumberOfSeats=2;Type="adult"}]};
                        {Id=6; Seats=[{NumberOfSeats=3;Type="adult"}]};
                        {Id=7; Seats=[{NumberOfSeats=4;Type="adult"}]};
                        {Id=8; Seats=[{NumberOfSeats=1;Type="wheelchair"};{NumberOfSeats=2;Type="companion"}]};
                        ])

let seatAssignments = AssignedSeats ([
                                        Seated({RequestId=2; Type="adult"; Position={Row="A";Column=1}});
                                        Seated({RequestId=2; Type="adult"; Position={Row="A";Column=2}});
                                        Seated({RequestId=2; Type="child"; Position={Row="A";Column=3}});
                                        Seated({RequestId=5; Type="adult"; Position={Row="A";Column=4}});
                                        Seated({RequestId=5; Type="adult"; Position={Row="A";Column=5}});
                                        NotSeated({Row="A"; Column=6});
                                        Seated({RequestId=3; Type="adult"; Position={Row="B";Column=1}});
                                        Seated({RequestId=3; Type="adult"; Position={Row="B";Column=2}});
                                        Seated({RequestId=3; Type="adult"; Position={Row="B";Column=3}});
                                        Seated({RequestId=1; Type="wheelchair"; Position={Row="B";Column=4}});
                                        Seated({RequestId=1; Type="companion"; Position={Row="B";Column=5}});
                                        NotSeated({Row="B";Column=6});
                                        Seated({RequestId=3; Type="adult"; Position={Row="C";Column=1}});
                                        Seated({RequestId=3; Type="adult"; Position={Row="C";Column=2}});
                                        Seated({RequestId=3; Type="adult"; Position={Row="C";Column=3}});
                                        Seated({RequestId=4; Type="child"; Position={Row="C";Column=4}});
                                        Seated({RequestId=4; Type="child"; Position={Row="C";Column=5}});
                                        Seated({RequestId=4; Type="child"; Position={Row="C";Column=6}});
                                        NotSeated({Row="D";Column=1});
                                        NotSeated({Row="D";Column=2});
                                        Seated({RequestId=4; Type="adult"; Position={Row="D";Column=3}});
                                        Seated({RequestId=4; Type="child"; Position={Row="D";Column=4}});
                                        Seated({RequestId=4; Type="child"; Position={Row="D";Column=5}});
                                        Seated({RequestId=4; Type="child"; Position={Row="D";Column=6}});
                                    ])
