## Problems

1. How do other terminals solve the problem of reading inputs?
  
  `fish-shell` first requires an existing terminal

  `podersosa` seems uses win32 api to draw text

  `gnome-terminall` no idea

  `python idle`

  `console2` seems to uses Windows CMD.exe as host

     we can see that from Task manager and *ConsoleView.cpp* which uses `CreateProcess` and `WriteProcessMemory`

  `PoshConsole` stands in front of *powershell* it seems

## Refs

> you mean what we call a "pseudo-tty" or a "terminal emulator" in unix. In windows, I guess it is called a "console host". 

from http://stackoverflow.com/questions/535212/programming-a-terminal-emulator-whats-in-it

