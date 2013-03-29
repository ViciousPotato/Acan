// include Fake lib
#r @"tools\FAKE\tools\FakeLib.dll"
open Fake 

let buildDir = @".\build\"

// Default target
Target "Default" (fun _ ->
  trace "Hello World from FAKE"
)

Target "Clean" (fun _ ->
  CleanDir buildDir
)

Target "BuildApp" (fun _ ->
)

// Dependencies
"Clean"
  ==> "BuildApp"
  ==> "Default"

// start build
Run "Default"
