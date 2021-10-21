@echo off
cd C:\D\Git_Hub\HowTo_CSharp\NuGet\NuGet_Temp
call :menu.init
:m_hgbdfksgsd
	echo ##################################
	call :menu.Choice1
	echo ##################################
	choice /c ews
	call :menu.Choice%ErrorLevel% do
goto :m_hgbdfksgsd

PAUSE
CLS
EXIT

:menu.init
	set menu.id=0
exit /b 0
rem w - upp
:menu.Choice1
	rem 0.
	if "%1" EQU "" (
		if %menu.id% EQU 0 (echo * 0. Exit)
		if %menu.id% NEQ 0 (echo 0. Exit)
	)else (if %menu.id% EQU 0 Exit)
	rem 1.
	if "%1" EQU "" (
		if %menu.id% EQU 1 (echo * nuget spec)
		if %menu.id% NEQ 1 (echo nuget spec)
	)else (if %menu.id% EQU 1 nuget spec)
	rem 2.
	if "%1" EQU "" (
		if %menu.id% EQU 2 (echo * notepad Package.nuspec)
		if %menu.id% NEQ 2 (echo notepad Package.nuspec)
	)else (if %menu.id% EQU 2 notepad Package.nuspec)
	rem 3.
	if "%1" EQU "" (
		if %menu.id% EQU 3 (echo * nuget pack)
		if %menu.id% NEQ 3 (echo nuget pack)
	)else (if %menu.id% EQU 3 nuget pack)
exit /b 0
rem s - doun
:menu.Choice2
	set /a menu.id= %menu.id%-1
exit /b 0
rem e - DO
:menu.Choice3
	set /a menu.id= %menu.id%+1
exit /b 0