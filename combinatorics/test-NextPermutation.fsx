(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

open Algorithms.Combinatorics.MyPermutation
open System.Diagnostics

let testcase1() = 
    // Test cases: find next permutation

    let answer = Some [|1; 4; 2; 3; 5; 6|]
    let result = NextPermutation [|1; 3; 6; 5; 4; 2|]
    Debug.Assert((result = answer),
                 "Test case 1: Wrong answer",
                 "result is {0}, should be {1}",
                 result.ToString(), answer.ToString())

let main() =
    testcase1()
    printfn "NextPermutation: OK"

main()
