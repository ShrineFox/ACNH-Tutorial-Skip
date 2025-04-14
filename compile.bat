set COMPILER="../acnh-eventflow-compiler/main.py"
set PYTHONPATH="C:\Python39\python.exe"

for /r %%a in (*.evfl) do %PYTHONPATH% %COMPILER% --functions functions.csv -d EventFlow/ %%a