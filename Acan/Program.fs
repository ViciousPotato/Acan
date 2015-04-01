open System
open System.Windows
open FsXaml

type window = XAML<"MainWindow.xaml">

[<STAThread()>]
[<EntryPoint>]
let main argv =
  let w = window()

  w.Root.MouseDown.Add (fun _ -> w.Root.DragMove())

  w.Root.Show()

  let app = Application()
  app.Run()
