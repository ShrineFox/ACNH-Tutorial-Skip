set COMPILER="../acnh-eventflow-compiler/main.py"
set PYTHONPATH="C:\Python39\python.exe"

for /r "EventFlow_Edited" %%a in (*.evfl) do %PYTHONPATH% %COMPILER% --functions functions.csv -d romfs/EventFlow/ %%a