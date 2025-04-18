set COMPILER="../acnh-eventflow-compiler/main.py"
set PYTHONPATH="C:\Python39\python.exe"
set BFEVFLPATH="C:\Users\Ryan\AppData\Roaming\Ryujinx\mods\contents\01006f8002326000\romfs\EventFlow"

for /r "EventFlow_Edited" %%a in (*.evfl) do %PYTHONPATH% %COMPILER% --functions functions.csv -d %BFEVFLPATH% %%a