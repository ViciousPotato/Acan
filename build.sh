# Build script used in mingw/msys

tools/FSharp/fsc.exe -I C:/Windows/Microsoft.NET/Framework64/v4.0.30319/ -I C:/Windows/Microsoft.NET/Framework64/v4.0.30319/WPF -r PresentationFramework.dll  --out:./build/Acan.exe src/Acan/Acan.fs

cp tools/FSharp/FSharp.Core.dll build/
