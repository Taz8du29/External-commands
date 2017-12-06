@echo off

Set file=%~pnx1
Del %file%.exe

Set CS_DIR=%windir%\Microsoft.NET\Framework

For /F "usebackq delims=" %%I In (`Dir /B /A:D /L %CS_DIR%`) Do (
	Echo Compiler version : %%I


	%CS_DIR%\%%I\csc.exe /nologo /out:"%file%.exe" "%file%" 2>NUL
	If Not ERRORLEVEL 1 (
		Echo Compilation : Done
	) Else (
		Echo Compilation : Failed
	)

	Echo ------------------------------------------------------------
)

Pause >NUL
