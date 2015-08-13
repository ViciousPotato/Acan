cd C:\MSDE\honglinz\Projects\Acan
xcopy /Y /d src\MainWindow.xaml build\Debug
xcopy /Y /d src\*.png build\Debug
xcopy /Y /d src\*.jpg build\Debug
fsc -g -r:System.dll -r:WindowsBase.dll -r:PresentationCore.dll -r:PresentationFramework.dll --target:exe --platform:x86 --nowarn:9 --win32res:src\Acan.res -o:build\Debug\Acan.exe src\Util.fs src\Acan.fs