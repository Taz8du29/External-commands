@echo off

set file=%~pnx1

del %file%.exe

for /f "delims=" %%I in ('dir /b /s "%windir%\microsoft.net\*csc.exe"') do ("%%I" /nologo /out:"%file%.exe" "%file%" 2>NUL
	Echo ------------------------------------------------------------
)

pause>nul