set DECOMPILER="../acnh-eventflow-decompiler/main.py"
set PYTHONPATH="C:\Python39\python.exe"
set BFEVFLPATH="C:\Users\Ryan\AppData\Roaming\Ryujinx\mods\contents\01006f8002326000\romfs\EventFlow"

for /r %BFEVFLPATH% %%a in (*.bfevfl) do %PYTHONPATH% %DECOMPILER% --functions functions.csv --out-dir ./EventFlow_Edited_Decompiled/ %%a