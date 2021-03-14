module Assignment

// Problem 1
let rec tribn n =
    if(n <= 0) then 0
    elif(n = 1 || n = 2) then 1
    else tribn(n-1) + tribn(n-2) + tribn(n-3)

// Problem 2
let rec tribn2 n = //didn't understand what you were asking for here, is this not already linear?
    if(n <= 0) then 0
    elif(n = 1 || n = 2) then 1
    else tribn(n-1) + tribn(n-2) + tribn(n-3)

// Problem 3
let rec last (lst:int list) = 
    let t = List.tail lst
    if(t = last)

// Problem 4
let fourth (lst:int list) =
    // write your code here
    0

// Problem 5
let everyfourth (lst:int list) =
    // write your code here
    []

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    []

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
    []
