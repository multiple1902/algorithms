(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

open Algorithms.Search.MyArray
open System.Diagnostics

let ubound = 42

let compare x y = 
    if x < y then -1 else
    if x > y then  1  else
    0

let map x = 2 * x + 1
let mapInvalid x = 2 * x

let arr = Array.init (ubound + 1) map

let testcase1() = 
    // Test cases: element in array
    for i in arr.GetLowerBound(0) .. arr.GetUpperBound(0) do
        let result = BinarySearch arr                    // array
                                  (arr.GetLowerBound 0)  // index
                                  (arr.GetLength     0)  // length
                                  (map i)                // value
                                  compare                // compare
        Debug.Assert((result = i),
                     "Test case 1: Should return index for element in array",
                     "var is {0}, result = {1}",
                     (map i).ToString(), result.ToString())


let testcase2() = 
    // Test cases: element NOT in array
    for i in arr.GetLowerBound(0) .. arr.GetUpperBound(0) do
        let result = BinarySearch arr                    // array
                                  (arr.GetLowerBound 0)  // index
                                  (arr.GetLength     0)  // length
                                  (mapInvalid i)         // value
                                  compare                // compare
        Debug.Assert((result < 0),
                     "Test case 2: Should return negative for element not in array.", 
                     "var is {0}, result = {1}",
                     (mapInvalid i).ToString(), result.ToString())

let testcase3() = 
    // Test cases: element NOT in array
    for var in [-100; -1; map(ubound + 1); map(ubound + 100)]  do
        let result = BinarySearch arr                    // array
                                  (arr.GetLowerBound 0)  // index
                                  (arr.GetLength     0)  // length
                                  var                    // value
                                  compare                // compare
        Debug.Assert((result < 0), 
                     "Test case 3: Should return negative for element not in array.", 
                     "var is {0}, result = {1}",
                     var.ToString(), result.ToString())

let main() =
    testcase1()
    testcase2()
    testcase3()
    printfn "BinarySearch: OK"

main()
