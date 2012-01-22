@echo off
nuget pack QuickFix.csproj -Prop Configuration=Release
for /f "delims=" %%x in ('dir *.nupkg /od /b') do set FileName=%%x
nuget push %FileName%