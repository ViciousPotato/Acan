#light
open System
open System.Windows

let win = new Window()
win.Title <- "Acan"
win.Show()

[<STAThread()>]
do
  let app = new Application() in
  app.Run() |> ignore
  
