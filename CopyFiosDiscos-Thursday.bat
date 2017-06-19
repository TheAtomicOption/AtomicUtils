@Echo OFF

ECHO Welcome %USERNAME%.
ECHO.
ECHO This batch program will prepare files for DMS upload. Please ensure that you have 7-zip installed in the default location before proceeding. This file was designed to execute on Windows XP only.
ECHO Press Ctrl-C now to abort.
ECHO.
Pause

Rem ##################Begin Parameter init.############################################

SET srcpath5=S:\Marketing\Analysis\FiosDiscosDms\Thursday\5 Day\
SET srcpath25=S:\Marketing\Analysis\FiosDiscosDms\Thursday\25 Day\

SET mypath=%CD%
FOR /F "TOKENS=1* DELIMS= " %%A IN ('DATE/T') DO SET CDATE=%%B
FOR /F "TOKENS=1,2 eol=/ DELIMS=/ " %%A IN ('DATE/T') DO SET mm=%%B
FOR /F "TOKENS=1,2 DELIMS=/ eol=/" %%A IN ('echo %CDATE%') DO SET dd=%%B
FOR /F "TOKENS=2,3 DELIMS=/ " %%A IN ('echo %CDATE%') DO SET yyyy=%%B 

Rem ##################End Parameter init ##############################################

Echo          %CDATE%
Copy "S:\csgrpts\1DAILY\2TUES\FIOS discos-2 days ago.csv" "%srcpath5%%yyyy%%mm%%dd%TueFIOSDiscos-2Day.csv" /Y
Copy "S:\csgrpts\1DAILY\3WEDS\FIOS discos-2 days ago.csv" "%srcpath5%%yyyy%%mm%%dd%WedFIOSDiscos-2Day.csv" /Y
Copy "S:\csgrpts\1DAILY\4THURS\FIOS discos-2 days ago.csv" "%srcpath5%%yyyy%%mm%%dd%ThuFIOSDiscos-2Day.csv" /Y


Copy "S:\csgrpts\1DAILY\2TUES\FIOS discos-25 days ago.csv" "%srcpath25%%yyyy%%mm%%dd%TueFIOSDiscos-25Day.csv" /Y
Copy "S:\csgrpts\1DAILY\3WEDS\FIOS discos-25 days ago.csv" "%srcpath25%%yyyy%%mm%%dd%WedFIOSDiscos-25Day.csv" /Y
Copy "S:\csgrpts\1DAILY\4THURS\FIOS discos-25 days ago.csv" "%srcpath25%%yyyy%%mm%%dd%ThuFIOSDiscos-25Day.csv" /Y


Echo          Copying Complete.
S:

REM Delete zip files if duplicates exist to prevent 7z errors

if EXIST "%srcpath5%%yyyy%%mm%%dd%FIOSDiscos-5Day.zip" DEL "%srcpath5%%yyyy%%mm%%dd%FIOSDiscos-5Day.zip"
if EXIST "%srcpath25%%yyyy%%mm%%dd%FIOSDiscos-25Day.zip" DEL "%srcpath25%%yyyy%%mm%%dd%FIOSDiscos-25Day.zip"
"%programfiles%\7-Zip\7z.exe" a "%srcpath5%%yyyy%%mm%%dd%FIOSDiscos-5Day.zip" "%srcpath5%%yyyy%%mm%%dd%*.csv"
"%programfiles%\7-Zip\7z.exe" a "%srcpath25%%yyyy%%mm%%dd%FIOSDiscos-25Day.zip" "%srcpath25%%yyyy%%mm%%dd%*.csv"

 
Copy "%srcpath5%%yyyy%%mm%%dd%FIOSDiscos-5Day.zip" ""S:\Marketing\Analysis\FiosDiscosDms\Thursday\"
Copy "%srcpath25%%yyyy%%mm%%dd%FIOSDiscos-25Day.zip" "S:\Marketing\Analysis\FiosDiscosDms\Thursday\"


Echo OFF
"ftp" -s:"%mypath%\FTPCommands-thurs.txt"
Echo OFF

REM Delete zip files to prevent re-upload during next run.
if EXIST "%srcpath5%%yyyy%%mm%%dd%FIOSDiscos-5Day.zip" DEL "%srcpath5%%yyyy%%mm%%dd%FIOSDiscos-5Day.zip"
if EXIST "%srcpath25%%yyyy%%mm%%dd%FIOSDiscos-25Day.zip" DEL "%srcpath25%%yyyy%%mm%%dd%FIOSDiscos-25Day.zip"

@Echo OFF
Echo.
If %ERRORLEVEL% NEQ 0 ECHO An error occured.
If %ERRORLEVEL% EQU 0 ECHO Operation Successful!
Pause

@ECHO OFF
