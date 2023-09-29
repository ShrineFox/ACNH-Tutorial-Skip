set DECOMPILER="../acnh-eventflow-decompiler/main.py"
set PYTHONPATH="%localAppData%\Programs\Python\Python37-32\python.exe"

for /r %%a in (*.bfevfl) do %PYTHONPATH% %DECOMPILER% --functions functions.csv --out-dir out/ %%a