// Learn more about F# at http://fsharp.org

open System
open Microsoft.Extensions.Configuration
open ProjectB

module AConfig =
    let projectAConfig = ConfigurationBuilder().AddJsonFile("appsettings.json",false, true).Build()

[<EntryPoint>]
let main argv =
    printfn "Project B config setting:  %s" (Config.projectBConfig.GetSection("MyTestConfig").Value)
    printfn "Project A config setting: %s" (AConfig.projectAConfig.GetSection("MyTestConfig").Value)
    printfn "Project A conn str: %s" (AConfig.projectAConfig.GetConnectionString("Db"))
    
    0 // return an integer exit code
