import os

tempDirPathFile = open("dir.TEMP", "r")
direc = list(tempDirPathFile.read())
tempDirPathFile.close()
if direc[len(direc) - 1] == "\n": direc[len(direc) - 1] = ""
if direc[len(direc) - 1] != "\\" and direc[len(direc) - 1] != "/": direc += "\\"
if direc[len(direc) - 3] == " ": direc[len(direc) - 3] = ""
direc = "".join(direc)
files = [f for f in os.listdir(direc) if ".rtf" in f and f[0] != "." and os.path.splitext(f)[1].lower() == ".rtf"]

for f in files:
    os.remove(direc + f)
