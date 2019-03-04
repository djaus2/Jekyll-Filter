@echo off

if %3.==. GOTO NoRefLink

set "RefLink=--reference-links"
GOTO RefLink

:NoRefLink
set RefLink=

:RefLink

IF %1.==. GOTO No1

@echo Going

if exist %1 (
GOTO Do1
) 

if exist %1.doc (
GOTO Do2
) 

if exist %1.docx (
GOTO Do3
) 

 ECHO File not found
GOTO End1

:Do1
ECHO Converting %1 to %1.md 
pandoc -s %1 --wrap=none  %RefLink%  -t markdown -o %1.md
GOTO End1

:Do2
ECHO Converting %1.doc to %1.md 
pandoc -s %1.doc --wrap=none %RefLink%  -t markdown -o %1.md
GOTO End1

:Do3
ECHO Converting %1.docx to %1.md 
pandoc -s %1.docx --wrap=none %RefLink%  -t markdown -o %1.md
GOTO End1

:No1
ECHO .
ECHO Word to Markdown
ECHO -----------------
ECHO Can be doc or docx Word document
ECHO .
ECHO No param 1: Need Word document filename or basename
ECHO .
ECHO Uses Pandoc
ECHO Any second paramater sets Use Ref Links (Place links at bottom)
ECHO See: https://ronn-bundgaard.dk/blog/convert-docx-to-markdown-with-pandoc/

GOTO End1


:End1
