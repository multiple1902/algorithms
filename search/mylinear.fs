(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

module Algorithms.Search.MyLinear

open System.Diagnostics

type CompareResult = 
     | COMPARE_HIT = 0
     | COMPARE_TOO_SMALL = -1
     | COMPARE_TOO_LARGE = 1

let FindGate low test = 

    let safeTest x = 
        if (x < low) then false else
        test x

    let compareEnter x = 
        let prev = safeTest (x - 1)
        let cur  = safeTest x
        if not cur then CompareResult.COMPARE_TOO_SMALL else
        if prev    then CompareResult.COMPARE_TOO_LARGE else
        CompareResult.COMPARE_HIT

    let rec binarySearch low high = 
                         //  ^^ high is unreachable
        let mid = (high + low) / 2
        match compareEnter mid with
        | CompareResult.COMPARE_TOO_LARGE -> 
                    binarySearch low mid
        | CompareResult.COMPARE_TOO_SMALL -> 
                    binarySearch mid high
        | CompareResult.COMPARE_HIT | _   -> mid

    let rec GateSearch offset step = 
        if test <| offset + step - 1 then
            binarySearch offset (offset + step)
        else GateSearch (offset + step) (step * 2)

    GateSearch low 1
        
    
