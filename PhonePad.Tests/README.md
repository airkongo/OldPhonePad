# Steps to Add Unit Tests
## Create a Test Project
dotnet new nunit -n PhonePad.Tests

## Add the Test Project to Your Solution
dotnet new sln -n OldPhonePad
dotnet sln OldPhonePad.sln add PhonePad.csproj
dotnet sln OldPhonePad.sln add PhonePad.Tests/PhonePad.Tests.csproj

## Add a Reference to the Main Project in the Test Project
dotnet add PhonePad.Tests/PhonePad.Tests.csproj reference PhonePad.csproj

## Run the Tests
dotnet test



### Summary

1. **Create a new test project** using `dotnet new nunit`.
2. **Add the test project** to your solution and reference the main project.
3. **Write and add unit tests** to the `PhonePadTests.cs` file.
4. **Run the tests** using `dotnet test`.
5. **Update `README.md`** to include instructions on running the tests.

This organization helps maintain clear separation between your main code and test code, making it easier to manage and extend your project.
