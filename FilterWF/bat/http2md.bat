@echo on

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

@echo Going

GOTO SkipCurl

curl %1 > temp.html


if exist temp.html (
GOTO Do3
) 

 ECHO File not found
GOTO End1

:SkipCurl

:Do3
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
