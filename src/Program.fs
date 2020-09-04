// Learn more about F# at http://fsharp.org

open System
let asyncFunc () = 
    async {
        do! Async.Sleep 5000
        printf "Inside Async:"
        return 42
    }

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let x = asyncFunc() |> Async.RunSynchronously
    printf "%i" x
    0 // return an integer exit code
