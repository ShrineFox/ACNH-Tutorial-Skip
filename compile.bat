set COMPILER="../acnh-eventflow-compiler/main.py"
set PYTHONPATH="%localAppData%\Programs\Python\Python37-32\python.exe"

for /r %%a in (*.evfl) do %PYTHONPATH% %COMPILER% --functions functions.csv -d EventFlow/ %%a