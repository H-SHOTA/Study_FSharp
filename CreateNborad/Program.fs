// F# の詳細については、http://fsharp.net を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。

[<EntryPoint>]
let main argv = 
    // 長さnの二次元配列(ボード)生成
    let board = Collections.Array2D.create 8 8 false
    // ボード出力
    for i in 0..7 do
        for j in 0..7 do
            match board.[i,j] with
                | true -> System.Console.Write("Ｑ");
                | false -> System.Console.Write("・");
        System.Console.WriteLine("");
    0 // 整数の終了コードを返します
