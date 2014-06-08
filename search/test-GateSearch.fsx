(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

open Algorithms.Search.MyLinear
open System.Diagnostics

let gate at x = x >= at
let ubound = 10000

let testcase1() = 
    // Test cases: without offset
    for i in 0 .. ubound do
        let result = FindGate 0 (gate i)

        Debug.Assert((result = i),
                     "Test case 1: Wrong answer",
                     "result is {0}, should be {1}",
                     result.ToString(), i.ToString())

let testcase2() = 
    // Test cases: with offset
    for i in 0 .. ubound do
        let result = FindGate 200 (gate i)

        Debug.Assert((result = (max 200 i)),
                     "Test case 2: Wrong answer",
                     "result is {0}, should be {1}",
                     result.ToString(), i.ToString())

let main() =
    testcase1()
    testcase2()
    printfn "FindRange: OK"

main()
