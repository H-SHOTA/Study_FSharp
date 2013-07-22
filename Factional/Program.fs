// F# の詳細については、http://fsharp.net を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

let rec Factional n = 
    if n > 0 then
        n * Factional (n-1) 
    else 
        1

[<EntryPoint>]
let main argv = 
    printfn "%d" ( Factional 4 )
    0 // 整数の終了コードを返します
