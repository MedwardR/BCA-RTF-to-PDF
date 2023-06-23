import os

tempDirPathFile = open("dir.TEMP", "r")
direc = list(tempDirPathFile.read())
if direc[len(direc) - 1] == "\n": direc[len(direc) - 1] = ""
if direc[len(direc) - 1] != "\\" and direc[len(direc) - 1] != "/": direc += "\\"
if direc[len(direc) - 3] == " ": direc[len(direc) - 3] = ""
direc = "".join(direc)
files = [f for f in os.listdir(direc) if ".rtf" in f and f[0] != "." and os.path.splitext(f)[1].lower() == ".rtf"]

i = 0
for fileName in files:
    i += 1
    print("  Appending text to file " + str(i) + "/" + str(len(files)))
    
    # Append text to document
    textToAppend = """
Replace this line with your own text
    """
    filePath = direc + fileName
    file = open(filePath, "r")
    lines = file.read().split("\n")
    file.close()
    lines[len(lines) - 2] = textToAppend
    
    newFileContents = ""
    for line in lines:
        newFileContents += line + "\n"
    
    file = open(filePath, "w")
    file.write(newFileContents)
    file.close()
