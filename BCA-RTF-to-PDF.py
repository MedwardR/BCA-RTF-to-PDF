import os
import json
from fpdf import FPDF

def appendFiles():
    direc = os.getcwd()
    files = os.listdir(direc)
    files = [f for f in files if os.path.isfile(os.path.join(direc, f)) and f[0] != "."]
    print(files)

print("BCA RTF to PDF Mass Converter and Formatter")
input("Press enter to start the operation...")

appendFiles()
