@echo on

if %3.==. GOTO NoRaw
GOTO Raw

:Raw
set "RefLink=--parse-raw"

:NoRaw
set RefLink=

IF %1.==. GOTO No1

@echo Going

if exist %1 (
    IF %2.==. GOTO Do11
    GOTO Do1
) 

if exist %1.html (
GOTO Do3
) 

 ECHO File not found
GOTO End1

:Do1
ECHO Converting %1 to %2.md 
pandoc %1 -o %2.md  %RefLink%
GOTO End1

:Do11
ECHO Converting %1 to %1.md 
pandoc %1 -o %2.md  %RefLink%
GOTO End1

:Do3
ECHO Converting %1.html to %1.md 
pandoc %1.html -o %1.md  %RefLink%
GOTO End1

:No1
ECHO .
ECHO HTML to Markdown
ECHO -----------------
ECHO Must be HTML document
ECHO .
ECHO No param 1: Need HTML document filename or basename
ECHO .
ECHO Uses Pandoc
ECHO Raw option if there is a second parameter


GOTO End1


:End1
