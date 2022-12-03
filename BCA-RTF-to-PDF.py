import os
import json
from fpdf import FPDF

input("\nBCA RTF to PDF Mass Converter and Formatter\nPress enter to start the operation...\n")

direc = os.getcwd()
files = [f for f in os.listdir(direc) if os.path.isfile(f) and f[0] != "." and os.path.splitext(f)[1].lower() == ".rtf"]

i = 0
for fileName in files:
    i += 1
    print("Processing file " + str(i) + "/" + str(len(files)))
    
    # Append text to document
    textToAppend = """
### This is a placeholder line ###
    """
    
    file = open(fileName, "r")
    lines = file.read().split("\n")
    lines[len(lines) - 2] = textToAppend
    
    newFileContents = ""
    for line in lines:
        newFileContents += line + "\n"
    file.close()
    
    file = open(fileName, "w")
    file.write(newFileContents)
    file.close()

input("\nOperation complete!\nPress any key to exit...")
