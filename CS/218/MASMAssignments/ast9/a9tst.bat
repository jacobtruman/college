@echo off

rem ****************************************
rem  Verify argument

if "%1"==""  goto  err_noparam
if not exist %1.exe  goto  err_nofile

rem ****************************************

cls
echo	Assignment #9 Batch File for Testing
echo.
echo	Executes the program multiple times using
echo	predefined input and compares the output
echo	known correct answers.
echo.
echo	There should be no differences between the
echo	program output and the master file.
echo.
echo.
echo.
echo.
pause

del outpt*.txt

echo ---------------------------------------
echo  Test #1

%1 <tst1.txt >outpt1.txt
fc outpt1.txt mstr1.txt

echo ---------------------------------------
echo  Test #2

%1 <tst2.txt >outpt2.txt
fc outpt2.txt mstr2.txt

echo ---------------------------------------
echo  Test #3

%1 <tst3.txt >outpt3.txt
fc outpt3.txt mstr3.txt

echo ---------------------------------------
echo  Test #4

%1 <tst4.txt >outpt4.txt
fc outpt4.txt mstr4.txt

echo ---------------------------------------
echo  Test #5

%1 <tst5.txt >outpt5.txt
fc outpt5.txt mstr5.txt

echo ---------------------------------------
echo  Test #6

%1 <tst6.txt >outpt6.txt
fc outpt6.txt mstr6.txt

echo ---------------------------------------
echo  Test #7

%1 <tst7.txt >outpt7.txt
fc outpt7.txt mstr7.txt

echo ---------------------------------------
echo  Test #8

%1 <tst8.txt >outpt8.txt
fc outpt8.txt mstr8.txt

echo ---------------------------------------
echo  Test #9

%1 <tst9.txt >outpt9.txt
fc outpt9.txt mstr9.txt


goto exit

rem ****************************************
rem  Error handling...

:err_noparam
echo Must provide executable file name.
echo.
goto exit

:err_nofile
echo File %1.exe does not exist.
echo.
goto exit

rem ****************************************
rem  Done

:exit
