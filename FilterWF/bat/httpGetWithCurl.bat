@echo on
@echo One= %1XX
@echo TWO= %2YY



IF %1.==. GOTO No1
IF %2.==. GOTO No1

@echo %1>%2
@echo =====================
curl %1>%2
GOTO End1

:No1
ECHO.
ECHO HTTP to Markdown
ECHO -----------------
ECHO.
ECHO No param 1 and or 2: Need Url and target
ECHO.
ECHO Uses Pandoc



GOTO End1


:End1
