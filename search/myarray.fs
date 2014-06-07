(* Weisi Dai <weisi@x-research.com>
 * All rights reserved.
 *)

module Algorithms.Search.MyArray

[<Literal>]
let SEARCH_NOT_FOUND = -1

let rec BinarySearch (array: 'a[]) index length (value: 'a) compare =
    // similar to System.Array.BinarySearch(...) in .Net
    if length <= 1 then 
        if (compare array.[index] value) = 0 then index else
        SEARCH_NOT_FOUND
    else
        let halfInterval = (length + 1) / 2
        let mid = index + halfInterval
        match (compare array.[mid] value) with
        | 0            -> BinarySearch array mid 0 value compare
        | x when x > 0 -> BinarySearch array 
                                       index (mid - index)
                                       value compare
        | _            -> BinarySearch array 
                                       mid   (index + length - mid) 
                                       value compare
        
