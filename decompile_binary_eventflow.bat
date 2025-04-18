set DECOMPILER="../acnh-eventflow-decompiler/main.py"
set PYTHONPATH="C:\Python39\python.exe"

for /r "romfs/EventFlow" %%a in (*.bfevfl) do %PYTHONPATH% %DECOMPILER% --functions functions.csv --out-dir ./EventFlow_Edited_Decompiled/ %%a