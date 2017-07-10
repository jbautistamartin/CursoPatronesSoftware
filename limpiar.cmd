@ECHO OFF
del /s *.bak 2>nul
del /s *.tmp 2>nul
del /s *.suo 2>nul

for /D /r %%i in (*) do (
	echo "%%i"
	rmdir  "%%i\.vs" /s/q 2>nul 
	rmdir  "%%i\obj" /s/q 2>nul 
	rmdir  "%%i\release" /s/q 2>nul
	rmdir  "%%i\bin" /s/q 2>nul
	rmdir  "%%i\debug" /s/q 2>nul
	rmdir  "%%i\build" /s/q 2>nul
)
