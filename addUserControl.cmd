@echo off
set pathProject=D:\Desktop\BCQuanLyCaNhanSinhVien\QuanLyCaNhanSinhVien\WFCTableList
set nameUserControl=WFCTableList



set pathCompileGacutil="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\gacutil.exe"
set pathCompileSn="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\sn.exe"

echo:
echo Tien hanh remove Global Assembly %nameUserControl%
echo:
cd /d "%pathProject%\bin\Debug"
%pathCompileGacutil% -u %nameUserControl%

echo:
@pause
cls

echo:
echo Bat dau tao khoa snk
echo:

cd /d "%pathProject%\obj\Debug"
%pathCompileSn% -k %nameUserControl%.snk
echo:
@pause
cls

set line=[assembly: AssemblyKeyName("%nameUserControl%")] 
for /f "tokens=*delims=" %%a in (%pathProject%\Properties\AssemblyInfo.cs) do if "%%a"=="%line%" goto Register

echo:
echo Ghi du lieu...
echo:>> "%pathProject%\Properties\AssemblyInfo.cs"
echo [assembly: AssemblyKeyName("%nameUserControl%")] >> "%pathProject%\Properties\AssemblyInfo.cs"
echo [assembly: AssemblyKeyFile("%nameUserControl%.snk")] >> "%pathProject%\Properties\AssemblyInfo.cs"
echo:
echo Ghi du lieu AssemblyInfo.cs thanh cong

:Register
cls
echo:
echo:
echo            Build Project
echo:
echo:
pause
cls

echo:
echo Tien hanh register Global Assembly %nameUserControl%
echo:
cd /d "%pathProject%\bin\Debug"
%pathCompileGacutil% -i %nameUserControl%.dll

echo:
@pause
exit;