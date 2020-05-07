// Learn more about F# at http://fsharp.org

open System
open Microsoft.Extensions.Configuration

open ProjectB.Config
    

[<EntryPoint>]
let main argv =
    printfn "Project B config setting: %s" (projectBConfig.GetSection("MyTestConfig").Value)
    printfn "Project B conn str: %s" (projectBConfig.GetConnectionString("Db"))
    0 // return an integer exit code
