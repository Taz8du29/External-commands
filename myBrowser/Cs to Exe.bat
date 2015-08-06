@echo off

set file=%~pnx1

del %file%.exe

for /f "delims=" %%I in ('dir /b /s "%windir%\Microsoft.NET\Framework\*csc.exe"') do ("%%I" /nologo /out:"%file%.exe" "%file%" /win32icon:"icon_browser_32x32.png" 2>NUL
	Echo ------------------------------------------------------------
)

pause>nul