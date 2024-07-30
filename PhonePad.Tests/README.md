# Steps to Add Unit Tests
## Create a Test Project
`dotnet new nunit -n PhonePad.Tests`

## Add the Test Project to Solution
`dotnet new sln -n OldPhonePad`

`dotnet sln OldPhonePad.sln add PhonePad.csproj`

`dotnet sln OldPhonePad.sln add PhonePad.Tests/PhonePad.Tests.csproj`

## Add a Reference to the Main Project in the Test Project
`dotnet add PhonePad.Tests/PhonePad.Tests.csproj reference PhonePad.csproj`

## Run the Tests
`dotnet test`
