file = open("text-to-append.txt", "r")
lines = file.read().split("\n")
lines = lines[3:len(lines)]
textToAppend = ""
for line in lines:
    textToAppend += line
    if line != lines[len(lines) - 1]:
        textToAppend += "\n"
file.close()

file = open("BCA-RTF-to-PDF.py", "r")
lines = file.read().split("\n")
lines[16] = textToAppend
newFileContents = ""
for line in lines:
    newFileContents += line
    if line != lines[len(lines) - 1]:
        newFileContents += "\n"
file.close()

file = open("BCA-RTF-to-PDF.py", "w")
file.write(newFileContents)
file.close()
