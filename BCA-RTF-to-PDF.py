import os
import json
from fpdf import FPDF

print("\nBCA RTF to PDF Mass Converter and Formatter")
input("Press enter to start the operation...")

direc = os.getcwd()
files = [f for f in os.listdir(direc) if os.path.isfile(f) and f[0] != "." and os.path.splitext(f)[1].lower() == ".rtf"]

i = 0
for fileName in files:
    i += 1
    print("Processing file " + str(i) + "/" + str(len(files)))
    
    # Append text to document
    file = open(fileName)
    
    file.close()
