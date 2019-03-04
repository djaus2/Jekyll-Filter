
IF %1.==. GOTO No1
IF %2.==. GOTO No1


GOTO Start

:No1
@echo Need two parameters
GOTO End

:Start
@echo %1
@echo %2
@ECHO Converting %1 to %2

if %3.==. GOTO NoTitle
pandoc -s -o %2 %1 -T %3
GOTO Done
:NoTitle
pandoc -s -o %2 %1 

:Done
@echo Done

:End