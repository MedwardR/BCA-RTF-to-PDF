import os

tempDirPathFile = open("dir.TEMP", "r")
direc = list(tempDirPathFile.read())
tempDirPathFile.close()
if direc[len(direc) - 1] == "\n": direc[len(direc) - 1] = ""
if direc[len(direc) - 1] != "\\" and direc[len(direc) - 1] != "/": direc += "\\"
if direc[len(direc) - 3] == " ": direc[len(direc) - 3] = ""
direc = "".join(direc)

file = open(direc + "_Table_of_Contents.htm", "r")
fileContents = file.read()
file.close()

fileContents = fileContents.replace(".rtf", ".pdf")

file = open(direc + "_Table_of_Contents.htm", "w")
file.write(fileContents)
file.close()
