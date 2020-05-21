//#load "../.paket/load/net45/FSharp.Data.SqlClient.fsx"

#load "../.paket/load/net45/FSharp.Data.SqlClient.fsx"

open FSharp.Data

[<Literal>]
let connStr = "Server=.;Initial catalog=SAFE_Bank;Trusted_Connection=true"

let GetData() = do
    use cmd = new SqlCommandProvider<"SELECT TOP(@topN) * from test1" , connStr>(connStr)
    cmd.Execute(topN = 3L) |> printfn "%A";;