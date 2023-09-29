set COMPILER="../acnh-eventflow-compiler/main.py"

for /r %%a in (*.evfl) do %localAppData%\Programs\Python\Python37-32\python.exe %%COMPILER%% --functions functions.csv -d Compiled/ %%a