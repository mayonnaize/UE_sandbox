set UE_ROOT=C:\UnrealEngine\UE_4.27
@REM C:\UnrealEngine\UE_4.27\Engine\Build\BatchFiles\RunUAT.bat
@REM クックまで実行
%UE_ROOT%\Engine\Build\BatchFiles\RunUAT.bat BuildGraph ^
    -script="C:\Projects\UE_Projects\UE427_Template\BuildGraph\BuildProject.xml" ^
    -target="Package Game Win64" ^
    -set:ProjectName=UE427_Template ^
    -Set:ProjectDir="C:\Projects\UE_Projects\UE427_Template" ^
    -Set:BuildConfig=Development ^
    -Set:OutputDir="C:\Projects\UE_Projects\UE427_Template\Packages"
