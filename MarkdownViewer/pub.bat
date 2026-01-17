dotnet publish /p:Platform=x64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.x64.pubxml
copy bin\X64\Release\net10.0\publish\win-x64\MarkdownViewer.exe bin\X64\Release\net10.0\publish\win-x64\MarkdownViewer.x64.exe
upx bin\X64\Release\net10.0\publish\win-x64\MarkdownViewer.x64.exe

dotnet publish /p:Platform=ARM64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.ARM64.pubxml
copy bin\ARM64\Release\net10.0\publish\win-arm64\MarkdownViewer.exe bin\ARM64\Release\net10.0\publish\win-arm64\MarkdownViewer.ARM64.exe

dotnet publish /p:Platform=x86 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.x86.pubxml
copy bin\x86\Release\net10.0\publish\win-x86\MarkdownViewer.exe bin\x86\Release\net10.0\publish\win-x86\MarkdownViewer.x86.exe