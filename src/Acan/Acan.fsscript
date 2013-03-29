#light
#I @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319"
#I @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\WPF"
#r @"PresentationCore.dll"
#r @"PresentationFramework.dll"

open System
open System.Windows

let win = new Window()
win.Title <- "Acan"
win.Show()

[<STAThread()>]
do
  let app = new Application() in
  app.Run() |> ignore
  
