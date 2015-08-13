module Util

open System
open System.IO
open System.Net
open System.Windows
open System.Windows.Media
open System.Windows.Controls
open System.Windows.Media
open System.Diagnostics
open System.Windows.Media.Imaging

let PathToImageSource path =
  let cvt = new ImageSourceConverter()
  cvt.ConvertFromString(path) :?> ImageSource