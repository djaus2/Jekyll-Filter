@echo off
@echo One= %1 Media dir
@echo TWO= %2 source url
@echo TWO= %3 output file

set MEDIADIR= %1
rem "C:\Users\DavidJones\source\repos\DJzBlog\Media"

GOTO SkipRaw

if %3.==. GOTO NoRaw
GOTO Raw

:Raw
set "RefLink=--parse-raw"

:NoRaw
set RefLink=

:SkipRaw

IF %1.==. GOTO No1
IF %2.==. GOTO No1
if %3.==. GOTO  Nol

@echo Going

@echo converting %2 to %3

rem curl %1 > %3
pandoc -s  --extract-media %MEDIADIR% -t markdown -o %3 -r html %2

rem pandoc  -s --extract-media c:\temp\azx\media -o two.md "https://azure.microsoft.com/en-au/services/devops/?&OCID=AID736751_SEM_E6fx72j0&MarinID=E6fx72j0_79439795863658_azure%20devops_be_c__1271035786647226_kwd-79439959028611:loc-9_"

rem if exist temp.html (
GOTO End1
) 

 rem ECHO File not found
GOTO End1

:Do3

:SkipCurl


ECHO Converting %1 to %2 

pandoc -o %2 -f html  %1 

rem pandoc temp.html -o temp.md  %RefLink%
rem pandoc -f html -t markdown temp.html> temp1.md
rem findstr /V ::: temp1.md >temp.md
rem echo --- > %2.md
rem echo layout: default >> %2.md
rem echo title: "%2" >> %2.md
rem echo --- >> %2.md
rem echo.  >> %2.md
rem type temp.md >> %2.md
rem del /q temp.md
rem del /q temp.html

rem findstr /V ::: temp1.md >%2.md
rem del /q temp1.md
GOTO End1

:No1
ECHO.
ECHO HTTP to Markdown
ECHO -----------------
ECHO.
ECHO No param 1 and or 2: Need Url and Title
ECHO.
ECHO Uses Pandoc



GOTO End1


:End1
