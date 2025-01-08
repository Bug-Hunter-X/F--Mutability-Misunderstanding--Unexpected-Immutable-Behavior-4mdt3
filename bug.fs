let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d\n" z
x <- 3
printf "%d\n" z // z will still print 3, not 4, because it was evaluated earlier.