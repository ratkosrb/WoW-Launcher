dotnet publish ..\src -p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true -p:DebugType=None -p:DebugSymbols=false -r win-x64 /p:Configuration=Release /p:platform="x64" --self-contained
