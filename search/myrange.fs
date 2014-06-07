(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

module Algorithms.Search.MyRange

open System.Diagnostics

type CompareResult = 
     | COMPARE_HIT = 0
     | COMPARE_TOO_SMALL = -1
     | COMPARE_TOO_LARGE = 1

let FindRange low high mid test = 
    Debug.Assert(test mid,
                 "FindRange: test on mid failed",
                 "mid is {0}, test mid is {1}",
                 mid, test mid)

    let safeTest x = 
        if (x < low) || (x > high) then false else
        test x

    let compareEnter x = 
        let prev = safeTest (x - 1)
        let cur  = safeTest x
        if not cur then CompareResult.COMPARE_TOO_SMALL else
        if prev    then CompareResult.COMPARE_TOO_LARGE else
        CompareResult.COMPARE_HIT

    let compareLeave x = 
        let cur  = safeTest x
        let succ = safeTest (x + 1)
        if not cur then CompareResult.COMPARE_TOO_LARGE else
        if succ    then CompareResult.COMPARE_TOO_SMALL else
        CompareResult.COMPARE_HIT

    let rec binarySearch low high compare =
        let mid = low + (high - low + 1) / 2
        match compare mid with
        | CompareResult.COMPARE_TOO_LARGE -> binarySearch low 
                                                          (mid - 1)
                                                          compare
        | CompareResult.COMPARE_TOO_SMALL -> binarySearch (mid + 1) 
                                                          high
                                                          compare
        | CompareResult.COMPARE_HIT | _   -> mid

    (binarySearch low mid  compareEnter,
     binarySearch mid high compareLeave)
        
    
