@echo off
title BCA RTF to PDF converter
color 0f

echo #############################################################################
echo:
echo   This program will convert your ugly RTF files into pretty PDF files!
echo:
echo   It will also append text to the document, which you can specify in line 17 of the `append_text.py` file
echo   located in this directory!
echo:
echo   Once this is done, it will adjust the `_Table_of_Contents.htm` file to link to your new PDF's!
echo:
echo #############################################################################

echo:
set /p dirPath="###  Enter target directory path: "
echo %dirPath% > dir.TEMP

echo:
python append_text.py

echo:
docto.exe -WD -f "%dirPath%" -fx .rtf -o "%dirPath%" -t wdFormatPDF

echo Removing old files...
python delete_rtfs.py

echo:
echo Updating table of contents...
python table_of_contents.py

del dir.TEMP

echo:
echo #############################
echo:
echo           Finished!
echo:
echo #############################
echo:
pause
