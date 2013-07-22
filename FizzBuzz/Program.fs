// F# の詳細については、http://fsharp.net を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

[<EntryPoint>]
let main argv = 
    for i = 1 to 100 do
        match i with
            | i when 0 = i % 15 -> printfn "FIZZBUZZ"
            | i when 0 = i % 3 -> printfn "FIZZ"
            | i when 0 = i % 5 -> printfn "BUZZ"
            | _ -> printfn"%d" i
    0
