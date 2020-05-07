module ProjectB.Config

open Microsoft.Extensions.Configuration
let projectBConfig = ConfigurationBuilder().AddJsonFile("appsettings.json",false, true).Build()