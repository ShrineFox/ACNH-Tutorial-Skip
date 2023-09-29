set DECOMPILER="../acnh-eventflow-decompiler/main.py"

for /r %%a in (*.bfevfl) do %%localAppData%%\Programs\Python\Python37-32\python.exe main.py --functions functions.csv --out-dir out/ %%a