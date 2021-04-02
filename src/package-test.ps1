$nugetCachePath = Join-Path "$([System.Environment]::GetFolderPath([System.Environment+SpecialFolder]::UserProfile))" ".nuget/packages"
Remove-Item "$nugetCachePath/dotVariant" -Recurse
dotnet build "dotVariant.sln" -t:Clean
./nuget sources add -name local -source "dotVariant/bin/Debug"
dotnet build "dotVariant/dotVariant.csproj" -p:PackageSelfTest=true
dotnet test "dotVariant.Test/dotVariant.Test.csproj" -p:PackageSelfTest=true
