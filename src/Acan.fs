open System
open System.IO
open System.Collections.ObjectModel
open System.Windows
open System.Windows.Controls
open System.Windows.Data
open System.Windows.Markup
open System.Windows.Input
open System.Windows.Interop
open System.Windows.Media
open System.Windows.Media.Imaging
open System.Xml
open System.Linq
open System.Runtime.InteropServices
open System.Threading
open System.Threading.Tasks
open System.Diagnostics

[<STAThread()>]
[<EntryPoint>]
let main argv =
  let window = XamlReader.Load(File.OpenRead("MainWindow.xaml")) :?> Window
  window.MouseDown.Add (fun _ -> window.DragMove())

  let logoImage = window.FindName("logoImg") :?> Image
  logoImage.Source <- Util.PathToImageSource (Path.Combine (Directory.GetCurrentDirectory (), "fish.png"))

  let cmdList = window.FindName("cmdList") :?> ListView
  let inputBox = window.FindName("inputBox") :?> TextBox

  inputBox.Focus() |> ignore

  let app = Application()
  app.Run(window)
