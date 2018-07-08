@echo off

del WLMergeSetup.exe

"c:\Program Files (x86)\Inno Setup 5\compil32.exe" /cc WLMergeSetup.iss

rem First find line with string "VERSION_SHORT" in wPimp.hdr
rem Then get third (3) token separated by default separator ' ' which is version number
rem - Since format of wPimp.hdr is '#define VARIABLE value' and we want 'value'
for /f "tokens=3" %%a in ('findstr /C:"VERSION_SHORT" AssemblyInfo.txt') do set ver=%%a

rem Remove quotes by replacing " with nothing
set version=%ver:"=%

rem Compress with version number in name: add archive, answer yes, maximum compression, stderr to nul
"C:\Program Files\7-Zip\7z.exe" a -y -mx9 Releases\WLMergeSetup-%version%.zip WLMergeSetup.exe > nul