let x = ref 1
let y = ref 2
let z = fun () -> !x + !y
printf "%d\n" (z ())
x := 3
printf "%d\n" (z ()) // Now z will print 5 because it's recomputed.