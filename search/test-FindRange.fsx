(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

open Algorithms.Search.MyRange
open System.Diagnostics

let inRange (low, high) x = (low <= x) && (x <= high)

let testcase1() = 
    // Test cases: find range

    let answer = (64, 89)
    let result = FindRange 0 100 80 (inRange answer)
    Debug.Assert((result = answer),
                 "Test case 1: Wrong answer",
                 "result is {0}, should be {1}",
                 result.ToString(), answer.ToString())

let main() =
    testcase1()
    printfn "FindRange: OK"

main()
