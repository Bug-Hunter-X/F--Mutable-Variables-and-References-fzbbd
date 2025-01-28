let mutable x = 10
let mutable y = 20
let z = ref 30

let add x y = x + y

printf "%d" (add x y)
printf "%d" !z

x <- 100
y <- 200

printf "%d" (add x y)
printf "%d" !z