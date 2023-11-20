@echo off
setlocal
rem Pobieranie aktualnej sciezki 
set "sciezka=%~dp0"
set "podfolder=FormApiSolution\DataBase"
set "sciezka=%sciezka%%podfolder%"

rem przjesce do nowej sciezki

cd /d "%sciezka%"
rem dotnet ef migrations add -s ..\FormAPI\FormAPI.csproj "SchoolMigration"
dotnet ef database update -s ..\FormAPI\FormAPI.csproj

rem dotnet run
rem http://localhost:5276/swagger/index.html

echo Aktualna sciezka: %sciezka%
endlocal
pause