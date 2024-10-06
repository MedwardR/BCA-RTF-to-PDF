import os

tempDirPathFile = open("dir.TEMP", "r")
direc = list(tempDirPathFile.read())
tempDirPathFile.close()
if direc[len(direc) - 1] == "\n": direc[len(direc) - 1] = ""
if direc[len(direc) - 1] != "\\" and direc[len(direc) - 1] != "/": direc += "\\"
if direc[len(direc) - 3] == " ": direc[len(direc) - 3] = ""
direc = "".join(direc)
files = [f for f in os.listdir(direc) if ".rtf" in f and f[0] != "." and os.path.splitext(f)[1].lower() == ".rtf"]

from datetime import date    
today = date.today().isoformat()

i = 0
for fileName in files:
    i += 1
    print("  Appending text to file " + str(i) + "/" + str(len(files)))
    
    # Append text to document
    textToAppend = """
    \line
    \line
    \line
    ______________________________          _______________________________          ______________ \line
    Provider Signature                             Provider Printed Name                          Date/Time \line
    }}
    """
    newFooter1 = "{\\footer\pard\\fs20 \\trowd\\trgaph0\cellx5760\cellx11520\pard\intbl\ql Exported from Epic on "
    newFooter2 = "\cell\pard\intbl\qr Page {\\field{\\fldinst PAGE}} of {\\field{\\fldinst NUMPAGES}}\cell\intbl\\row\line\line}\\trowd\\trgaph0\\trleft0"
    
    filePath = direc + fileName
    file = open(filePath, "r")
    lines = file.read().split("\n")
    file.close()
    lines[9] = newFooter1 + today + newFooter2
    lines[len(lines) - 2] = textToAppend
    
    newFileContents = ""
    for line in lines:
        newFileContents += line + "\n"
    
    file = open(filePath, "w")
    file.write(newFileContents)
    file.close()
