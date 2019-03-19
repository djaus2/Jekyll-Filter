@echo off
@echo md2html.bat

set "RefLink=--reference-links"
//set "RefLink=--parse-raw"

IF %1.==. GOTO No1
IF %2.==. GOTO No1
IF %3.==. GOTO No1

@echo BlogSite Root =  %1
set MEDIADIR=%1
@echo Source = %3
@echo Destination = %2
@echo Converting %1 to %2
IF %4.==. GOTO Start1
@echo Option Title = %4

GOTO Start2

:No1
@echo Need at least three parameters (BlogsiteRoot Output Target [Title])
GOTO End

:Start1
@echo on
pandoc --extract-media %MEDIADIR%  -s -o %4 %2
@echo off
GOTO Done

:Start2
@echo on
pandoc  --extract-media %MEDIADIR% -s -o %3 %2 -T %4
@echo off
GOTO Done


:Done
@echo Done

:End