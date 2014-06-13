(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

module Algorithms.Combinatorics.MyPermutation

let NextPermutation (current: 'a []) =
    let rec findRev pos = 
        if pos = 0 then None else
        if current.[pos - 1] < current.[pos] then Some pos else
        findRev (pos - 1)
    let last = current.GetUpperBound 0
    match findRev last with
    | None     -> None
    | Some pos -> let lowest = current.[pos .. last]
                               |> Array.filter ((<) current.[pos - 1])
                               |> Seq.ofArray |> Seq.min
                  current.[pos - 1 .. last]
                      |> Array.filter ((<>) lowest)
                      |> Array.sort
                  |> Array.append [| lowest |]
                  |> Array.append current.[0 .. pos - 2]
                  |> Some

